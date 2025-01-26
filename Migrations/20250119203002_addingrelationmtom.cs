using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheClubGymproject.Migrations
{
    /// <inheritdoc />
    public partial class addingrelationmtom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classesmembers",
                columns: table => new
                {
                    classesID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    membersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classesmembers", x => new { x.classesID, x.membersID });
                    table.ForeignKey(
                        name: "FK_classesmembers_Classes_classesID",
                        column: x => x.classesID,
                        principalTable: "Classes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_classesmembers_Members_membersID",
                        column: x => x.membersID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_classesmembers_membersID",
                table: "classesmembers",
                column: "membersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "classesmembers");
        }
    }
}
