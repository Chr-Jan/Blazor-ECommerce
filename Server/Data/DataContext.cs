namespace BlazorECommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {

        }

        //Seed data

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new {p.ProductId, p.ProductTypeId});

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                Id = 1,
                Name = "Books",
                Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "Video-games"
                }
                );

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Default" },
                 new ProductType { Id = 2, Name = "Paperback" },
                  new ProductType { Id = 3, Name = "E-Book" },
                   new ProductType { Id = 4, Name = "Audiobook" },
                    new ProductType { Id = 5, Name = "Stream" },
                     new ProductType { Id = 6, Name = "Blu-Ray" },
                      new ProductType { Id = 7, Name = "VHS" },
                       new ProductType { Id = 8, Name = "Ultra HD Blu-ray" },
                        new ProductType { Id = 9, Name = "PC" },
                         new ProductType { Id = 10, Name = "Playstation" },
                         new ProductType { Id = 11, Name = "Xbox" }
                );
    

            modelBuilder.Entity<Product>().HasData
                (
                    new Product
                    {
                        Id = 1,
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Nineteen Eighty-Four",
                        Description = "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany.[4] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg",
                        CategoryId = 1,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Shanghai Baby",
                        Description = "Shanghai Baby is a novel written by Chinese author Wei Hui. It was originally published in China in 1999. The English translation was published in 2001.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Shanghai_Baby.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        CategoryId = 2,
                        Title = "The Matrix",
                        Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                    },
                    new Product
                    {
                        Id = 5,
                        CategoryId = 2,
                        Title = "Back to the Future",
                        Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                    },
                    new Product
                    {
                        Id = 6,
                        CategoryId = 2,
                        Title = "Toy Story",
                        Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",

                    },
                    new Product
                    {
                        Id = 7,
                        CategoryId = 3,
                        Title = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",

                    },
                    new Product
                    {
                        Id = 8,
                        CategoryId = 3,
                        Title = "Diablo II",
                        Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    },
                    new Product
                    {
                        Id = 9,
                        CategoryId = 3,
                        Title = "Day of the Tentacle",
                        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                        Featured = true
                    },
                    new Product
                    {
                        Id = 10,
                        CategoryId = 3,
                        Title = "Xbox",
                        Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    },
                    new Product
                    {
                        Id = 11,
                        CategoryId = 3,
                        Title = "Super Nintendo Entertainment System",
                        Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    },
                    new Product
                    {
                        Id = 12,
                        Title = "Brave New World",
                        Description = "Brave New World is a dystopian novel written by Aldous Huxley. It was published in 1932 and explores the dangers of a technologically advanced society.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/62/BraveNewWorld_FirstEdition.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 13,
                        Title = "Fahrenheit 451",
                        Description = "Fahrenheit 451 is a novel by Ray Bradbury, published in 1953. It presents a future American society where books are outlawed and 'firemen' burn any that are found.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/db/Fahrenheit_451_1st_ed_cover.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 14,
                        Title = "Dune",
                        Description = "Dune is a science fiction novel by Frank Herbert, first published in 1965. It is set in the distant future amidst a feudal interstellar society.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg",
                        CategoryId = 1,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 15,
                        Title = "Neuromancer",
                        Description = "Neuromancer is a science fiction novel by William Gibson, published in 1984. It is one of the best-known works in the cyberpunk genre.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Neuromancer_%28Book%29.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 16,
                        Title = "Snow Crash",
                        Description = "Snow Crash is a science fiction novel by Neal Stephenson, published in 1992. It explores themes of virtual reality, linguistics, and the impact of technology on society.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Snowcrash.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 17,
                        Title = "The Hunger Games",
                        Description = "The Hunger Games is a dystopian novel by Suzanne Collins, published in 2008. It follows the story of Katniss Everdeen in a post-apocalyptic world.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/39/The_Hunger_Games_cover.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 18,
                        Title = "The Martian",
                        Description = "The Martian is a science fiction novel by Andy Weir, published in 2011. It tells the story of an astronaut stranded on Mars and his struggle for survival.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/71/The_Martian_%28Weir_novel%29.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 19,
                        Title = "Dark Matter",
                        Description = "Dark Matter is a science fiction thriller novel by Blake Crouch, published in 2016. It explores the concept of alternate realities and choices.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/3e/Crouch_DarkMatter.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 20,
                        Title = "The Expanse: Leviathan Wakes",
                        Description = "Leviathan Wakes is a science fiction novel by James S.A. Corey, published in 2011. It is the first book in The Expanse series.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/08/Leviathan_Wakes.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 21,
                        Title = "The Left Hand of Darkness",
                        Description = "The Left Hand of Darkness is a science fiction novel by Ursula K. Le Guin, published in 1969. It explores themes of gender and politics in a distant world.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/88/TheLeftHandOfDarkness1stEd.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 22,
                        CategoryId = 2,
                        Title = "Blade Runner",
                        Description = "Blade Runner is a 1982 science fiction film directed by Ridley Scott. It is loosely based on Philip K. Dick's novel 'Do Androids Dream of Electric Sheep?'",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9f/Blade_Runner_%281982_poster%29.png",
                    },
                    new Product
                    {
                        Id = 23,
                        CategoryId = 2,
                        Title = "Inception",
                        Description = "Inception is a 2010 science fiction action film written and directed by Christopher Nolan. It explores the concept of shared dreaming and subconscious manipulation.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg",
                    },
                    new Product
                    {
                        Id = 24,
                        CategoryId = 2,
                        Title = "The Truman Show",
                        Description = "The Truman Show is a 1998 satirical science fiction psychological comedy-drama film directed by Peter Weir. It stars Jim Carrey as Truman Burbank.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/cd/Trumanshow.jpg",
                    },
                    new Product
                    {
                        Id = 25,
                        CategoryId = 2,
                        Title = "Eternal Sunshine of the Spotless Mind",
                        Description = "Eternal Sunshine of the Spotless Mind is a 2004 romantic science fiction comedy-drama film directed by Michel Gondry. It stars Jim Carrey and Kate Winslet.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Eternal_Sunshine_of_the_Spotless_Mind.png",
                    },
                    new Product
                    {
                        Id = 26,
                        CategoryId = 2,
                        Title = "Interstellar",
                        Description = "Interstellar is a 2014 science fiction film directed by Christopher Nolan. It follows a group of astronauts who travel through a wormhole in search of a new home for humanity.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg",
                    },
                    new Product
                    {
                        Id = 27,
                        CategoryId = 2,
                        Title = "The Fifth Element",
                        Description = "The Fifth Element is a 1997 science fiction film directed by Luc Besson. It stars Bruce Willis, Milla Jovovich, and Gary Oldman.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/65/Fifth_element_poster_%281997%29.jpg",
                    },
                    new Product
                    {
                        Id = 28,
                        CategoryId = 2,
                        Title = "A Clockwork Orange",
                        Description = "A Clockwork Orange is a 1971 dystopian crime film adapted, produced, and directed by Stanley Kubrick, based on Anthony Burgess's 1962 novel of the same name.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/73/A_Clockwork_Orange_%281971%29.png",
                    },
                    new Product
                    {
                        Id = 29,
                        CategoryId = 2,
                        Title = "The Adjustment Bureau",
                        Description = "The Adjustment Bureau is a 2011 science fiction romantic thriller film directed by George Nolfi, based on the Philip K. Dick short story 'Adjustment Team'.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/1c/The_Adjustment_Bureau_Poster.jpg",
                    },
                    new Product
                    {
                        Id = 30,
                        CategoryId = 2,
                        Title = "Ex Machina",
                        Description = "Ex Machina is a 2014 science fiction psychological thriller film written and directed by Alex Garland. It examines the nature of artificial intelligence and consciousness.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/ba/Ex-machina-uk-poster.jpg",
                    },
                    new Product
                    {
                        Id = 31,
                        CategoryId = 3,
                        Title = "World of Warcraft",
                        Description = "World of Warcraft is a massively multiplayer online role-playing game (MMORPG) released in 2004 by Blizzard Entertainment. It is the fourth released game set in the Warcraft fantasy universe.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/65/World_of_Warcraft.png",
                    },
                    new Product
                    {
                        Id = 32,
                        CategoryId = 3,
                        Title = "The Legend of Zelda: Breath of the Wild",
                        Description = "The Legend of Zelda: Breath of the Wild is an action-adventure game developed and published by Nintendo for the Nintendo Switch and Wii U consoles. It is the 19th installment in the Legend of Zelda series.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg",
                    },
                    new Product
                    {
                        Id = 33,
                        CategoryId = 3,
                        Title = "Fortnite",
                        Description = "Fortnite is a battle royale game developed and published by Epic Games. It was released in 2017 and has become a cultural phenomenon with a large player base.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/0e/FortniteLogo.svg",
                    },
                    new Product
                    {
                        Id = 34,
                        CategoryId = 3,
                        Title = "Red Dead Redemption 2",
                        Description = "Red Dead Redemption 2 is an action-adventure game developed and published by Rockstar Games. It was released in 2018 as the third entry in the Red Dead series.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/44/Red_Dead_Redemption_II.jpg",
                    },
                    new Product
                    {
                        Id = 35,
                        CategoryId = 3,
                        Title = "Minecraft",
                        Description = "Minecraft is a sandbox video game developed and published by Mojang. The game was created by Markus Persson and released in 2011.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png",
                    },
                    new Product
                    {
                        Id = 36,
                        CategoryId = 3,
                        Title = "Assassin's Creed Valhalla",
                        Description = "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal and published by Ubisoft. It was released in 2020 as the twelfth major installment in the Assassin's Creed series.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/ff/Assassin%27s_Creed_Valhalla_cover.jpg",
                    },
                    new Product
                    {
                        Id = 37,
                        CategoryId = 3,
                        Title = "Overwatch",
                        Description = "Overwatch is a team-based multiplayer first-person shooter developed and published by Blizzard Entertainment. It was released in 2016 and has gained popularity for its diverse cast of characters.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/51/Overwatch_cover_art.jpg",
                    },
                    new Product
                    {
                        Id = 38,
                        CategoryId = 3,
                        Title = "Cyberpunk 2077",
                        Description = "Cyberpunk 2077 is an action role-playing game developed and published by CD Projekt. It was released in 2020 and is set in an open-world dystopian future.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9f/Cyberpunk_2077_box_art.jpg",
                        Featured = true
                    },
                    new Product
                    {
                        Id = 39,
                        CategoryId = 3,
                        Title = "Final Fantasy VII Remake",
                        Description = "Final Fantasy VII Remake is an action role-playing game developed and published by Square Enix. It is a remake of the 1997 game Final Fantasy VII.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/ce/FFVIIRemake.png",
                    },
                    new Product
                    {
                        Id = 40,
                        CategoryId = 3,
                        Title = "The Witcher 3: Wild Hunt",
                        Description = "The Witcher 3: Wild Hunt is an action role-playing game developed and published by CD Projekt. It was released in 2015 and is based on the book series by Andrzej Sapkowski.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg",
                    }
                 );

            modelBuilder.Entity<ProductVariant>().HasData
                (
                new ProductVariant { ProductId = 1, ProductTypeId = 2, Price = 9.99m, OriginalPrice = 19.99m },
                new ProductVariant { ProductId = 2, ProductTypeId = 2, Price = 6.99m, OriginalPrice = 14.99m },
                new ProductVariant { ProductId = 2, ProductTypeId = 3, Price = 3.99m, OriginalPrice = 10.99m },
                new ProductVariant { ProductId = 2, ProductTypeId = 4, Price = 2.99m, OriginalPrice = 11.99m },
                new ProductVariant { ProductId = 3, ProductTypeId = 2, Price = 8.99m, OriginalPrice = 16.99m },
                new ProductVariant { ProductId = 4, ProductTypeId = 6, Price = 4.99m, OriginalPrice = 12.99m },
                new ProductVariant { ProductId = 5, ProductTypeId = 6, Price = 3.99m, OriginalPrice = 10.99m },
                new ProductVariant { ProductId = 6, ProductTypeId = 5, Price = 2.99m, OriginalPrice = 8.99m },
                new ProductVariant { ProductId = 7, ProductTypeId = 9, Price = 49.99m, OriginalPrice = 59.99m },
                new ProductVariant { ProductId = 8, ProductTypeId = 9, Price = 9.99m, OriginalPrice = 19.99m },
                new ProductVariant { ProductId = 9, ProductTypeId = 9, Price = 14.99m, OriginalPrice = 24.99m },
                new ProductVariant { ProductId = 10, ProductTypeId = 10, Price = 159.99m, OriginalPrice = 199.99m },
                new ProductVariant { ProductId = 11, ProductTypeId = 10, Price = 79.99m, OriginalPrice = 99.99m },
                new ProductVariant { ProductId = 12, ProductTypeId = 2, Price = 7.99m, OriginalPrice = 15.99m },
                new ProductVariant { ProductId = 13, ProductTypeId = 2, Price = 8.49m, OriginalPrice = 17.99m },
                new ProductVariant { ProductId = 14, ProductTypeId = 2, Price = 10.99m, OriginalPrice = 21.99m },
                new ProductVariant { ProductId = 15, ProductTypeId = 2, Price = 9.99m, OriginalPrice = 18.99m },
                new ProductVariant { ProductId = 16, ProductTypeId = 2, Price = 11.99m, OriginalPrice = 22.99m },
                new ProductVariant { ProductId = 17, ProductTypeId = 2, Price = 12.99m, OriginalPrice = 25.99m },
                new ProductVariant { ProductId = 18, ProductTypeId = 2, Price = 14.99m, OriginalPrice = 28.99m },
                new ProductVariant { ProductId = 19, ProductTypeId = 2, Price = 13.99m, OriginalPrice = 26.99m },
                new ProductVariant { ProductId = 20, ProductTypeId = 2, Price = 15.99m, OriginalPrice = 29.99m },
                new ProductVariant { ProductId = 21, ProductTypeId = 2, Price = 11.49m, OriginalPrice = 23.99m },
                new ProductVariant { ProductId = 22, ProductTypeId = 6, Price = 5.99m, OriginalPrice = 11.99m },
                new ProductVariant { ProductId = 23, ProductTypeId = 6, Price = 7.99m, OriginalPrice = 15.99m },
                new ProductVariant { ProductId = 24, ProductTypeId = 6, Price = 4.49m, OriginalPrice = 9.99m },
                new ProductVariant { ProductId = 25, ProductTypeId = 6, Price = 6.49m, OriginalPrice = 12.99m },
                new ProductVariant { ProductId = 26, ProductTypeId = 6, Price = 3.79m, OriginalPrice = 8.99m },
                new ProductVariant { ProductId = 27, ProductTypeId = 6, Price = 5.49m, OriginalPrice = 10.99m },
                new ProductVariant { ProductId = 28, ProductTypeId = 6, Price = 2.89m, OriginalPrice = 6.99m },
                new ProductVariant { ProductId = 29, ProductTypeId = 6, Price = 4.99m, OriginalPrice = 9.99m },
                new ProductVariant { ProductId = 30, ProductTypeId = 6, Price = 3.29m, OriginalPrice = 7.99m },
                new ProductVariant { ProductId = 31, ProductTypeId = 9, Price = 29.99m, OriginalPrice = 39.99m },
                new ProductVariant { ProductId = 32, ProductTypeId = 9, Price = 39.99m, OriginalPrice = 49.99m },
                new ProductVariant { ProductId = 33, ProductTypeId = 9, Price = 19.99m, OriginalPrice = 29.99m },
                new ProductVariant { ProductId = 34, ProductTypeId = 9, Price = 49.99m, OriginalPrice = 59.99m },
                new ProductVariant { ProductId = 35, ProductTypeId = 9, Price = 9.99m, OriginalPrice = 19.99m },
                new ProductVariant { ProductId = 36, ProductTypeId = 9, Price = 59.99m, OriginalPrice = 69.99m },
                new ProductVariant { ProductId = 37, ProductTypeId = 9, Price = 29.99m, OriginalPrice = 39.99m },
                new ProductVariant { ProductId = 38, ProductTypeId = 9, Price = 39.99m, OriginalPrice = 49.99m },
                new ProductVariant { ProductId = 39, ProductTypeId = 9, Price = 49.99m, OriginalPrice = 59.99m },
                new ProductVariant { ProductId = 40, ProductTypeId = 9, Price = 29.99m, OriginalPrice = 39.99m }
                );

               
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<ProductVariant> ProductVariant { get; set; }

    }
}
