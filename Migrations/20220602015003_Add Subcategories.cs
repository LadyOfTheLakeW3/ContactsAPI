using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsAPI.Migrations
{
    public partial class AddSubcategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubcategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    SubcategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubcategoryName = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.SubcategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SubcategoryId",
                table: "Categories",
                column: "SubcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Subcategories_SubcategoryId",
                table: "Categories",
                column: "SubcategoryId",
                principalTable: "Subcategories",
                principalColumn: "SubcategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Subcategories_SubcategoryId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SubcategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SubcategoryId",
                table: "Categories");
        }
    }
}
