using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PostgresWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialMigrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConstructionProjects",
                table: "ConstructionProjects");

            migrationBuilder.AlterColumn<string>(
                name: "projectName",
                table: "ConstructionProjects",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "projectId",
                table: "ConstructionProjects",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "ConstructionProjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "endDate",
                table: "ConstructionProjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "startDate",
                table: "ConstructionProjects",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConstructionProjects",
                table: "ConstructionProjects",
                column: "projectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ConstructionProjects",
                table: "ConstructionProjects");

            migrationBuilder.DropColumn(
                name: "projectId",
                table: "ConstructionProjects");

            migrationBuilder.DropColumn(
                name: "description",
                table: "ConstructionProjects");

            migrationBuilder.DropColumn(
                name: "endDate",
                table: "ConstructionProjects");

            migrationBuilder.DropColumn(
                name: "startDate",
                table: "ConstructionProjects");

            migrationBuilder.AlterColumn<string>(
                name: "projectName",
                table: "ConstructionProjects",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConstructionProjects",
                table: "ConstructionProjects",
                column: "projectName");
        }
    }
}
