using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YoungJamRecordsShop.DataAccess.Migrations
{
    public partial class AddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Format",
                table: "AlbumType",
                newName: "AlbumFormat");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlbumFormat",
                table: "AlbumType",
                newName: "Format");
        }
    }
}
