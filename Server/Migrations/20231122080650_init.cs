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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide to the Galaxy" },
                    { 2, 1, "Nineteen Eighty-Four (also published as 1984) is a dystopian novel and cautionary tale by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the authoritarian state in the novel on the Soviet Union in the era of Stalinism, and Nazi Germany.[4] More broadly, the novel examines the role of truth and facts within societies and the ways in which they can be manipulated.", "https://upload.wikimedia.org/wikipedia/en/5/51/1984_first_edition_cover.jpg", 6.99m, "Nineteen Eighty-Four" },
                    { 3, 1, "Shanghai Baby is a novel written by Chinese author Wei Hui. It was originally published in China in 1999. The English translation was published in 2001.", "https://upload.wikimedia.org/wikipedia/en/0/0c/Shanghai_Baby.jpg", 8.99m, "Shanghai Baby" },
                    { 4, 2, "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", 4.99m, "The Matrix" },
                    { 5, 2, "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", 3.99m, "Back to the Future" },
                    { 6, 2, "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", 2.99m, "Toy Story" },
                    { 7, 3, "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", 49.99m, "Half-Life 2" },
                    { 8, 3, "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 9.99m, "Diablo II" },
                    { 9, 3, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", 14.99m, "Day of the Tentacle" },
                    { 10, 3, "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", 159.99m, "Xbox" },
                    { 11, 3, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 79.99m, "Super Nintendo Entertainment System" },
                    { 12, 1, "Brave New World is a dystopian novel written by Aldous Huxley. It was published in 1932 and explores the dangers of a technologically advanced society.", "https://upload.wikimedia.org/wikipedia/en/6/62/BraveNewWorld_FirstEdition.jpg", 7.99m, "Brave New World" },
                    { 13, 1, "Fahrenheit 451 is a novel by Ray Bradbury, published in 1953. It presents a future American society where books are outlawed and 'firemen' burn any that are found.", "https://upload.wikimedia.org/wikipedia/en/d/db/Fahrenheit_451_1st_ed_cover.jpg", 8.49m, "Fahrenheit 451" },
                    { 14, 1, "Dune is a science fiction novel by Frank Herbert, first published in 1965. It is set in the distant future amidst a feudal interstellar society.", "https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg", 10.99m, "Dune" },
                    { 15, 1, "Neuromancer is a science fiction novel by William Gibson, published in 1984. It is one of the best-known works in the cyberpunk genre.", "https://upload.wikimedia.org/wikipedia/en/4/4b/Neuromancer_%28Book%29.jpg", 9.99m, "Neuromancer" },
                    { 16, 1, "Snow Crash is a science fiction novel by Neal Stephenson, published in 1992. It explores themes of virtual reality, linguistics, and the impact of technology on society.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Snowcrash.jpg", 11.99m, "Snow Crash" },
                    { 17, 1, "The Hunger Games is a dystopian novel by Suzanne Collins, published in 2008. It follows the story of Katniss Everdeen in a post-apocalyptic world.", "https://upload.wikimedia.org/wikipedia/en/3/39/The_Hunger_Games_cover.jpg", 12.99m, "The Hunger Games" },
                    { 18, 1, "The Martian is a science fiction novel by Andy Weir, published in 2011. It tells the story of an astronaut stranded on Mars and his struggle for survival.", "https://upload.wikimedia.org/wikipedia/commons/7/71/The_Martian_%28Weir_novel%29.jpg", 14.99m, "The Martian" },
                    { 19, 1, "Dark Matter is a science fiction thriller novel by Blake Crouch, published in 2016. It explores the concept of alternate realities and choices.", "https://upload.wikimedia.org/wikipedia/en/3/3e/Crouch_DarkMatter.jpg", 13.99m, "Dark Matter" },
                    { 20, 1, "Leviathan Wakes is a science fiction novel by James S.A. Corey, published in 2011. It is the first book in The Expanse series.", "https://upload.wikimedia.org/wikipedia/en/0/08/Leviathan_Wakes.jpg", 15.99m, "The Expanse: Leviathan Wakes" },
                    { 21, 1, "The Left Hand of Darkness is a science fiction novel by Ursula K. Le Guin, published in 1969. It explores themes of gender and politics in a distant world.", "https://upload.wikimedia.org/wikipedia/en/8/88/TheLeftHandOfDarkness1stEd.jpg", 11.49m, "The Left Hand of Darkness" },
                    { 22, 2, "Blade Runner is a 1982 science fiction film directed by Ridley Scott. It is loosely based on Philip K. Dick's novel 'Do Androids Dream of Electric Sheep?'", "https://upload.wikimedia.org/wikipedia/en/9/9f/Blade_Runner_%281982_poster%29.png", 5.99m, "Blade Runner" },
                    { 23, 2, "Inception is a 2010 science fiction action film written and directed by Christopher Nolan. It explores the concept of shared dreaming and subconscious manipulation.", "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg", 7.99m, "Inception" },
                    { 24, 2, "The Truman Show is a 1998 satirical science fiction psychological comedy-drama film directed by Peter Weir. It stars Jim Carrey as Truman Burbank.", "https://upload.wikimedia.org/wikipedia/en/c/cd/Trumanshow.jpg", 4.49m, "The Truman Show" },
                    { 25, 2, "Eternal Sunshine of the Spotless Mind is a 2004 romantic science fiction comedy-drama film directed by Michel Gondry. It stars Jim Carrey and Kate Winslet.", "https://upload.wikimedia.org/wikipedia/en/a/a4/Eternal_Sunshine_of_the_Spotless_Mind.png", 6.49m, "Eternal Sunshine of the Spotless Mind" },
                    { 26, 2, "Interstellar is a 2014 science fiction film directed by Christopher Nolan. It follows a group of astronauts who travel through a wormhole in search of a new home for humanity.", "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg", 3.79m, "Interstellar" },
                    { 27, 2, "The Fifth Element is a 1997 science fiction film directed by Luc Besson. It stars Bruce Willis, Milla Jovovich, and Gary Oldman.", "https://upload.wikimedia.org/wikipedia/en/6/65/Fifth_element_poster_%281997%29.jpg", 5.49m, "The Fifth Element" },
                    { 28, 2, "A Clockwork Orange is a 1971 dystopian crime film adapted, produced, and directed by Stanley Kubrick, based on Anthony Burgess's 1962 novel of the same name.", "https://upload.wikimedia.org/wikipedia/en/7/73/A_Clockwork_Orange_%281971%29.png", 2.89m, "A Clockwork Orange" },
                    { 29, 2, "The Adjustment Bureau is a 2011 science fiction romantic thriller film directed by George Nolfi, based on the Philip K. Dick short story 'Adjustment Team'.", "https://upload.wikimedia.org/wikipedia/en/1/1c/The_Adjustment_Bureau_Poster.jpg", 4.99m, "The Adjustment Bureau" },
                    { 30, 2, "Ex Machina is a 2014 science fiction psychological thriller film written and directed by Alex Garland. It examines the nature of artificial intelligence and consciousness.", "https://upload.wikimedia.org/wikipedia/en/b/ba/Ex-machina-uk-poster.jpg", 3.29m, "Ex Machina" },
                    { 31, 3, "World of Warcraft is a massively multiplayer online role-playing game (MMORPG) released in 2004 by Blizzard Entertainment. It is the fourth released game set in the Warcraft fantasy universe.", "https://upload.wikimedia.org/wikipedia/en/6/65/World_of_Warcraft.png", 29.99m, "World of Warcraft" },
                    { 32, 3, "The Legend of Zelda: Breath of the Wild is an action-adventure game developed and published by Nintendo for the Nintendo Switch and Wii U consoles. It is the 19th installment in the Legend of Zelda series.", "https://upload.wikimedia.org/wikipedia/en/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg", 39.99m, "The Legend of Zelda: Breath of the Wild" },
                    { 33, 3, "Fortnite is a battle royale game developed and published by Epic Games. It was released in 2017 and has become a cultural phenomenon with a large player base.", "https://upload.wikimedia.org/wikipedia/commons/0/0e/FortniteLogo.svg", 19.99m, "Fortnite" },
                    { 34, 3, "Red Dead Redemption 2 is an action-adventure game developed and published by Rockstar Games. It was released in 2018 as the third entry in the Red Dead series.", "https://upload.wikimedia.org/wikipedia/en/4/44/Red_Dead_Redemption_II.jpg", 49.99m, "Red Dead Redemption 2" },
                    { 35, 3, "Minecraft is a sandbox video game developed and published by Mojang. The game was created by Markus Persson and released in 2011.", "https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png", 9.99m, "Minecraft" },
                    { 36, 3, "Assassin's Creed Valhalla is an action role-playing video game developed by Ubisoft Montreal and published by Ubisoft. It was released in 2020 as the twelfth major installment in the Assassin's Creed series.", "https://upload.wikimedia.org/wikipedia/en/f/ff/Assassin%27s_Creed_Valhalla_cover.jpg", 59.99m, "Assassin's Creed Valhalla" },
                    { 37, 3, "Overwatch is a team-based multiplayer first-person shooter developed and published by Blizzard Entertainment. It was released in 2016 and has gained popularity for its diverse cast of characters.", "https://upload.wikimedia.org/wikipedia/en/5/51/Overwatch_cover_art.jpg", 29.99m, "Overwatch" },
                    { 38, 3, "Cyberpunk 2077 is an action role-playing game developed and published by CD Projekt. It was released in 2020 and is set in an open-world dystopian future.", "https://upload.wikimedia.org/wikipedia/en/9/9f/Cyberpunk_2077_box_art.jpg", 39.99m, "Cyberpunk 2077" },
                    { 39, 3, "Final Fantasy VII Remake is an action role-playing game developed and published by Square Enix. It is a remake of the 1997 game Final Fantasy VII.", "https://upload.wikimedia.org/wikipedia/en/c/ce/FFVIIRemake.png", 49.99m, "Final Fantasy VII Remake" },
                    { 40, 3, "The Witcher 3: Wild Hunt is an action role-playing game developed and published by CD Projekt. It was released in 2015 and is based on the book series by Andrzej Sapkowski.", "https://upload.wikimedia.org/wikipedia/en/0/0c/Witcher_3_cover_art.jpg", 29.99m, "The Witcher 3: Wild Hunt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
