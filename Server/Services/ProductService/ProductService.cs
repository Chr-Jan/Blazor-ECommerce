namespace BlazorECommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetFeaturedProducts()
        {
            var resposnce = new ServiceResponse<List<Product>>()
            {
                Data = await _context.Products
                    .Where(p=>p.Featured)
                    .Include(p=>p.Variants)
                    .ToListAsync()
            };

            return resposnce;
        }

        public async Task<ServiceResponse<Product>> GetProductById(int id)
        {
            var response = new ServiceResponse<Product>();
            var product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.ProductType)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this product does not exist.";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var products = await _context.Products
                .Include(p => p.Variants)
                .ToListAsync();
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var reponse = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products
                .Where(p => p.Category.Url
                .ToLower()
                .Equals(categoryUrl.ToLower()))
                .Include(p => p.Variants)
                .ToListAsync()
            };

            return reponse;
        }

        public async Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText)
        {
            var products = await FindProductsBySearchText(searchText);

            List<string> result = new List<string>();

            foreach (var product in products)
            {
                if (product.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Title);
                }

                if(product.Description != null)
                {
                    var punctuation = product.Description
                        .Where(char.IsPunctuation)
                        .Distinct()
                        .ToArray();

                    var words = product.Description
                        .Split()
                        .Select(w => w.Trim(punctuation));

                    foreach(var word in words)
                    {
                        if(word.Contains(searchText, StringComparison.OrdinalIgnoreCase) && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }
            }

            return new ServiceResponse<List<string>> { Data = result };
        }

            public async Task<ServiceResponse<ProductSearchResultDTO>> SearchProducts(string searchText, int page)
            {

            // Number of results to display per page in the paginated list
            // (set to 2 for two results per page)
            var pageResults = 2f;


            // Calculate the total number of pages based on the total number of results and results per page
            var pageCount = Math.Ceiling((await FindProductsBySearchText(searchText)).Count / pageResults);

            // Fetch the products for the current page using pagination
            var products = await _context.Products
                                .Where(p => p.Title.ToLower().Contains(searchText.ToLower())
                                           || p.Description.ToLower().Contains(searchText.ToLower()))
                                .Include(p => p.Variants)
                                .Skip((page - 1) * (int)pageResults)
                                .Take((int)pageResults)
                                .ToListAsync();


            var response = new ServiceResponse<ProductSearchResultDTO>
                {
                    Data = new ProductSearchResultDTO
                    {
                        Products = products,
                        CurrentPage = page,
                        Pages = (int)pageCount
                    }
                };
                return response;
            }

            private async Task<List<Product>> FindProductsBySearchText(string searchText)
            {
                return await _context.Products
                                .Where(p => p.Title.ToLower().Contains(searchText.ToLower())
                                || p.Description.
                                ToLower().
                                Contains(searchText.ToLower()))
                                .Include(p => p.Variants)
                                .ToListAsync();
            }
    }
}
