global using BlazorECommerce.Shared;
global using Microsoft.EntityFrameworkCore;
global using BlazorECommerce.Server.Data;
global using Microsoft.AspNetCore.ResponseCompression;
global using BlazorECommerce.Server.Services.ProductService;
global using BlazorECommerce.Server.Services.CategoryService;

namespace BlazorECommerce
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            // adding Cors
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("BlazorCors", policy =>
                {
                    policy.
                    WithOrigins("http://localhost:7032")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            // swagger #part 1
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();

            var app = builder.Build();

            //for adding swagger #part 2
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //for adding swagger #part 3
            app.UseSwagger();

            app.UseHttpsRedirection();

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();


            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile("index.html");

            app.UseCors("BlazorCors");

            app.Run();
        }
    }
}