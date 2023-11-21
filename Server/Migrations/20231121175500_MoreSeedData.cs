using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorECommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/d/db/Fahrenheit_451_1st_ed_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/d/d5/Snowcrash.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/7/71/The_Martian_%28Weir_novel%29.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/3/3e/Crouch_DarkMatter.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/0/08/Leviathan_Wakes.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/8/88/TheLeftHandOfDarkness1stEd.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/9/9f/Blade_Runner_%281982_poster%29.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/c/cd/Trumanshow.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/a/a4/Eternal_Sunshine_of_the_Spotless_Mind.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/7/73/A_Clockwork_Orange_%281971%29.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/1/1c/The_Adjustment_Bureau_Poster.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/b/ba/Ex-machina-uk-poster.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/6/65/World_of_Warcraft.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/c/c6/The_Legend_of_Zelda_Breath_of_the_Wild.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/0/0e/FortniteLogo.svg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/5/51/Minecraft_cover.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/f/ff/Assassin%27s_Creed_Valhalla_cover.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/9/9f/Cyberpunk_2077_box_art.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/c/ce/FFVIIRemake.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/d/db/Fahrenheit_451_1st_edition.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/9/90/Dune_-_F.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/e/e0/Snowcrash.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/c/c3/The_Martian.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/f/f5/Dark_Matter_%28Crouch_novel%29.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/a/a7/Leviathan_Wakes_%28James_S._A._Corey%29.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/e/e3/The_Left_Hand_of_Darkness_%28first_edition%29.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/5/53/Blade_Runner_poster.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/7/7f/Inception_ver3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/8/8b/Trumanshow.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/6/62/Eternal_sunshine_of_the_spotless_mind_ver3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/4/48/Clockwork_orangeA.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/f/f1/Adjustment_bureau.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/b/ba/Exmachinaposter.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/9/91/WoW_Box_Art1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/0/0d/The_Legend_of_Zelda_Breath_of_the_Wild.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/0/03/Fortnite_Box_Art.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/1/1c/Minecraftboxart.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/f/f5/Assassin%27s_Creed_Valhalla.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/2/21/Cyberpunk_2077_box_art.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/c/cf/FFVIIRemake.png");
        }
    }
}
