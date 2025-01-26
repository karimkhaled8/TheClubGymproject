using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheClubGymproject.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_membershiptypes_membershiptypesID",
                table: "Members");

            migrationBuilder.DropTable(
                name: "membershiptypes");

            migrationBuilder.DropIndex(
                name: "IX_Members_membershiptypesID",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "membershiptypesID",
                table: "Members");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "membershiptypesID",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "membershiptypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membershiptypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_membershiptypesID",
                table: "Members",
                column: "membershiptypesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_membershiptypes_membershiptypesID",
                table: "Members",
                column: "membershiptypesID",
                principalTable: "membershiptypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
