using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookServiceAPIUsingCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Tbl_Book");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Book",
                table: "Tbl_Book",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Book",
                table: "Tbl_Book");

            migrationBuilder.RenameTable(
                name: "Tbl_Book",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BookId");
        }
    }
}
