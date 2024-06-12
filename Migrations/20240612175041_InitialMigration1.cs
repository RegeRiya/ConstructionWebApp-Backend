using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ConstructionProjects",
                newName: "projectName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "projectName",
                table: "ConstructionProjects",
                newName: "Name");
        }
    }
}
