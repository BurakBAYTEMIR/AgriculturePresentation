using Microsoft.EntityFrameworkCore.Migrations;

namespace AgriculturePresentation.DataAccess.Migrations
{
    public partial class mig_add_service_class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Calss1",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Calss2",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calss1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Calss2",
                table: "Services");
        }
    }
}
