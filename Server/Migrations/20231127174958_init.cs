using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorECommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_ProductType_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Books", "books" },
                    { 2, "Movies", "movies" },
                    { 3, "Video Games", "Video-games" }
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Default" },
                    { 2, "Paperback" },
                    { 3, "E-Book" },
                    { 4, "Audiobook" },
                    { 5, "Stream" },
                    { 6, "Blu-Ray" },
                    { 7, "VHS" },
                    { 8, "Ultra HD Blu-ray" },
                    { 9, "PC" },
                    { 10, "Playstation" },
                    { 11, "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { 2, 1, "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany.[4] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.", "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg", "Nineteen Eighty-Four" },
                    { 3, 1, "Shanghai Baby is a novel written by Chinese author Wei Hui. It was originally published in China in 1999. The English translation was published in 2001.", "https://upload.wikimedia.org/wikipedia/en/0/0c/Shanghai_Baby.jpg", "Shanghai Baby" },
                    { 4, 2, "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { 5, 2, "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { 6, 2, "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { 7, 3, "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { 8, 3, "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { 9, 3, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { 10, 3, "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { 11, 3, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { 12, 1, "Brave New World is a dystopian novel written by Aldous Huxley. It was published in 1932 and explores the dangers of a technologically advanced society.", "https://upload.wikimedia.org/wikipedia/en/6/62/BraveNewWorld_FirstEdition.jpg", "Brave New World" },
                    { 13, 1, "Fahrenheit 451 is a novel by Ray Bradbury, published in 1953. It presents a future American society where books are outlawed and 'firemen' burn any that are found.", "https://upload.wikimedia.org/wikipedia/en/d/db/Fahrenheit_451_1st_ed_cover.jpg", "Fahrenheit 451" },
                    { 14, 1, "Dune is a science fiction novel by Frank Herbert, first published in 1965. It is set in the distant future amidst a feudal interstellar society.", "https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg", "Dune" },
                    { 15, 1, "Neuromancer is a science fiction novel by William Gibson, published in 1984. It is one of the best-known works in the cyberpunk genre.", "https://upload.wikimedia.org/wikipedia/en/4/4b/Neuromancer_%28Book%29.jpg", "Neuromancer" },
                    { 16, 1, "Snow Crash is a science fiction novel by Neal Stephenson, published in 1992. It explores themes of virtual reality, linguistics, and the impact of technology on society.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Snowcrash.jpg", "Snow Crash" },
                    { 17, 1, "The Hunger Games is a dystopian novel by Suzanne Collins, published in 2008. It follows the story of Katniss Everdeen in a post-apocalyptic world.", "https://upload.wikimedia.org/wikipedia/en/3/39/The_Hunger_Games_cover.jpg", "The Hunger Games" },
                    { 18, 1, "The Martian is a science fiction novel by Andy Weir, published in 2011. It tells the story of an astronaut stranded on Mars and his struggle for survival.", "https://upload.wikimedia.org/wikipedia/commons/7/71/The_Martian_%28Weir_novel%29.jpg", "The Martian" },
                    { 19, 1, "Dark Matter is a science fiction thriller novel by Blake Crouch, published in 2016. It explores the concept of alternate realities and choices.", "https://upload.wikimedia.org/wikipedia/en/3/3e/Crouch_DarkMatter.jpg", "Dark Matter" },
                    { 20, 1, "Leviathan Wakes is a science fiction novel by James S.A. Corey, published in 2011. It is the first book in The Expanse series.", "https://upload.wikimedia.org/wikipedia/en/0/08/Leviathan_Wakes.jpg", "The Expanse: Leviathan Wakes" },
                    { 21, 1, "The Left Hand of Darkness is a science fiction novel by Ursula K. Le Guin, published in 1969. It explores themes of gender and politics in a distant world.", "https://upload.wikimedia.org/wikipedia/en/8/88/TheLeftHandOfDarkness1stEd.jpg", "The Left Hand of Darkness" },
                    { 22, 2, "Blade Runner is a 1982 science fiction film directed by Ridley Scott. It is loosely based on Philip K. Dick's novel 'Do Androids Dream of Electric Sheep?'", "https://upload.wikimedia.org/wikipedia/en/9/9f/Blade_Runner_%281982_poster%29.png", "Blade Runner" },
                    { 23, 2, "Inception is a 2010 science fiction action film written and directed by Christopher Nolan. It explores the concept of shared dreaming and subconscious manipulation.", "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg", "Inception" },
                    { 24, 2, "The Truman Show is a 1998 satirical science fiction psychological comedy-drama film directed by Peter Weir. It stars Jim Carrey as Truman Burbank.", "https://upload.wikimedia.org/wikipedia/en/c/cd/Trumanshow.jpg", "The Truman Show" },
                    { 25, 2, "Eternal Sunshine of the Spotless Mind is a 2004 romantic science fiction comedy-drama film directed by Michel Gondry. It stars Jim Carrey and Kate Winslet.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Eternal_Sunshine_of_the_Spotless_Mind.png", "Eternal Sunshine of the Spotless Mind" },
                    { 26, 2, "Interstellar is a 2014 science fiction film directed by Christopher Nolan. It follows a group of astronauts who travel through a wormhole in search of a new home for humanity.", "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg", "Interstellar" },
                    { 27, 2, "The Fifth Element is a 1997 science fiction film directed by Luc Besson. It stars Bruce Willis, Milla Jovovich, and Gary Oldman.", "https://upload.wikimedia.org/wikipedia/en/6/65/Fifth_element_poster_%281997%29.jpg", "The Fifth Element" },
                    { 28, 2, "A Clockwork Orange is a 1971 dystopian crime film adapted, produced, and directed by Stanley Kubrick, based on Anthony Burgess's 1962 novel of the same name.", "https://upload.wikimedia.org/wikipedia/en/7/73/A_Clockwork_Orange_%281971%29.png", "A Clockwork Orange" },
                    { 29, 2, "The Adjustment Bureau is a 2011 science fiction romantic thriller film directed by George Nolfi, based on the Philip K. Dick short story 'Adjustment Team'.", "https://upload.wikimedia.org/wikipedia/en/1/1c/The_Adjustment_Bureau_Poster.jpg", "The Adjustment Bureau" },
                    { 30, 2, "Ex Machina is a 2014 science fiction psychological thriller film written and directed by Alex Garland. It examines the nature of artificial intelligence and consciousness.", "https://upload.wikimedia.org/wikipedia/en/b/ba/Ex-machina-uk-poster.jpg", "Ex Machina" },
                    { 31, 3, "World of Warcraft is a massively multiplayer online role-playing game (MMORPG) released in 2004 by Blizzard Entertainment. It is the fourth released game set in the Warcraft fantasy universe.", "https://upload.wikimedia.org/wikipedia/en/6/65/World_of_Warcraft.png", "World of Warcraft" },
                    { 32, 3, "The Legend of Zelda: Breath of the Wild is an action-adventure game developed and published by Nintendo for the Nintendo Switch and Wii U consoles. It is the 19th installment in the Legend of Zelda series.", "https://upload.wikimedia.org/wikipedia/en/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg", "The Legend of Zelda: Breath of the Wild" },
                    { 33, 3, "Fortnite is a battle royale game developed and published by Epic Games. It was released in 2017 and has become a cultural phenomenon with a large player base.", "https://upload.wikimedia.org/wikipedia/commons/0/0e/FortniteLogo.svg", "Fortnite" },
                    { 34, 3, "Red Dead Redemption 2 is an action-adventure game developed and published by Rockstar Games. It was released in 2018 as the third entry in the Red Dead series.", "https://upload.wikimedia.org/wikipedia/en/4/44/Red_Dead_Redemption_II.jpg", "Red Dead Redemption 2" },
                    { 35, 3, "Minecraft is a sandbox video game developed and published by Mojang. The game was created by Markus Persson and released in 2011.", "https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png", "Minecraft" },
                    { 36, 3, "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal and published by Ubisoft. It was released in 2020 as the twelfth major installment in the Assassin's Creed series.", "https://upload.wikimedia.org/wikipedia/en/f/ff/Assassin%27s_Creed_Valhalla_cover.jpg", "Assassin's Creed Valhalla" },
                    { 37, 3, "Overwatch is a team-based multiplayer first-person shooter developed and published by Blizzard Entertainment. It was released in 2016 and has gained popularity for its diverse cast of characters.", "https://upload.wikimedia.org/wikipedia/en/5/51/Overwatch_cover_art.jpg", "Overwatch" },
                    { 38, 3, "Cyberpunk 2077 is an action role-playing game developed and published by CD Projekt. It was released in 2020 and is set in an open-world dystopian future.", "https://upload.wikimedia.org/wikipedia/en/9/9f/Cyberpunk_2077_box_art.jpg", "Cyberpunk 2077" },
                    { 39, 3, "Final Fantasy VII Remake is an action role-playing game developed and published by Square Enix. It is a remake of the 1997 game Final Fantasy VII.", "https://upload.wikimedia.org/wikipedia/en/c/ce/FFVIIRemake.png", "Final Fantasy VII Remake" },
                    { 40, 3, "The Witcher 3: Wild Hunt is an action role-playing game developed and published by CD Projekt. It was released in 2015 and is based on the book series by Andrzej Sapkowski.", "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg", "The Witcher 3: Wild Hunt" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 2, 19.99m, 9.99m },
                    { 2, 2, 14.99m, 6.99m },
                    { 3, 2, 16.99m, 8.99m },
                    { 4, 6, 12.99m, 4.99m },
                    { 5, 6, 10.99m, 3.99m },
                    { 6, 5, 8.99m, 2.99m },
                    { 7, 9, 59.99m, 49.99m },
                    { 8, 9, 19.99m, 9.99m },
                    { 9, 9, 24.99m, 14.99m },
                    { 10, 10, 199.99m, 159.99m },
                    { 11, 10, 99.99m, 79.99m },
                    { 12, 2, 15.99m, 7.99m },
                    { 13, 2, 17.99m, 8.49m },
                    { 14, 2, 21.99m, 10.99m },
                    { 15, 2, 18.99m, 9.99m },
                    { 16, 2, 22.99m, 11.99m },
                    { 17, 2, 25.99m, 12.99m },
                    { 18, 2, 28.99m, 14.99m },
                    { 19, 2, 26.99m, 13.99m },
                    { 20, 2, 29.99m, 15.99m },
                    { 21, 2, 23.99m, 11.49m },
                    { 22, 6, 11.99m, 5.99m },
                    { 23, 6, 15.99m, 7.99m },
                    { 24, 6, 9.99m, 4.49m },
                    { 25, 6, 12.99m, 6.49m },
                    { 26, 6, 8.99m, 3.79m },
                    { 27, 6, 10.99m, 5.49m },
                    { 28, 6, 6.99m, 2.89m },
                    { 29, 6, 9.99m, 4.99m },
                    { 30, 6, 7.99m, 3.29m },
                    { 31, 9, 39.99m, 29.99m },
                    { 32, 9, 49.99m, 39.99m },
                    { 33, 9, 29.99m, 19.99m },
                    { 34, 9, 59.99m, 49.99m },
                    { 35, 9, 19.99m, 9.99m },
                    { 36, 9, 69.99m, 59.99m },
                    { 37, 9, 39.99m, 29.99m },
                    { 38, 9, 49.99m, 39.99m },
                    { 39, 9, 59.99m, 49.99m },
                    { 40, 9, 39.99m, 29.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_ProductTypeId",
                table: "ProductVariant",
                column: "ProductTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
