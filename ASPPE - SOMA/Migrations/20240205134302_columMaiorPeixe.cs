using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPPE___SOMA.Migrations
{
    /// <inheritdoc />
    public partial class columMaiorPeixe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MaiorPeixe",
                table: "Equipes",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaiorPeixe",
                table: "Equipes");
        }
    }
}
