using Microsoft.EntityFrameworkCore.Migrations;

namespace LenaForm.Data.Migrations
{
    public partial class AddedEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    required = table.Column<bool>(type: "bit", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Formid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.id);
                    table.ForeignKey(
                        name: "FK_Fields_Forms_Formid",
                        column: x => x.Formid,
                        principalTable: "Forms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fields_Formid",
                table: "Fields",
                column: "Formid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
