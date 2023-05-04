using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GCommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Dune is a 1965 science-fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelaznys This Immortal for the Hugo Award in 1966, and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune saga, and in 2003 was cited as the worlds best-selling science fiction novel.", "https://m.media-amazon.com/images/I/81ym3QUd3KL.jpg", "Dune 1", 12.59m },
                    { 2, "Quarantine is a 1992 science fiction novel by Australian writer Greg Egan. It was first published as a hardback in 1992 by Victor Gollancz Ltd. It won the 1993 John W. Campbell Award. The story is set in a near-future world in which right-wing politicians gain power in the United States, Russia, and Australia, and a mysterious scientific discovery is made in Western Australia, which causes many countries to quarantine the entire continent. The novel follows several characters as they react to the discovery and the quarantine.", "https://upload.wikimedia.org/wikipedia/en/5/5d/Quarantine_%28Greg_Egan_novel%29_cover_art.jpg", "Quarantine", 9.29m },
                    { 3, "The Martian is a 2011 science fiction novel written by Andy Weir. It was his debut novel under his own name. It was originally self-published in 2011; Crown Publishing purchased the rights and re-released it in 2014. The story follows an American astronaut, Mark Watney, as he becomes stranded alone on Mars in 2035 and must improvise in order to survive.", "https://upload.wikimedia.org/wikipedia/en/c/c3/The_Martian_2014.jpg", "The Martian", 11.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
