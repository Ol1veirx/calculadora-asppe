using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPPE___SOMA.Migrations
{
    /// <inheritdoc />
    public partial class columPointsAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Pontos",
                table: "Equipes",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "Equipes");
        }
    }
}
