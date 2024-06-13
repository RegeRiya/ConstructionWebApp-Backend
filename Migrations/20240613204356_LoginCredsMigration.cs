using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostgresWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class LoginCredsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginCredentials",
                columns: table => new
                {
                    userName = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginCredentials", x => x.userName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginCredentials");
        }
    }
}
