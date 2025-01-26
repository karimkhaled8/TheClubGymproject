using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheClubGymproject.Migrations
{
    /// <inheritdoc />
    public partial class addingrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "membersID",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "membershiptypesID",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "trainersID",
                table: "Classes",
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
                name: "IX_Payments_membersID",
                table: "Payments",
                column: "membersID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_membershiptypesID",
                table: "Members",
                column: "membershiptypesID");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_trainersID",
                table: "Classes",
                column: "trainersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_trainers_trainersID",
                table: "Classes",
                column: "trainersID",
                principalTable: "trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_membershiptypes_membershiptypesID",
                table: "Members",
                column: "membershiptypesID",
                principalTable: "membershiptypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Members_membersID",
                table: "Payments",
                column: "membersID",
                principalTable: "Members",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_trainers_trainersID",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_membershiptypes_membershiptypesID",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Members_membersID",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "membershiptypes");

            migrationBuilder.DropIndex(
                name: "IX_Payments_membersID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Members_membershiptypesID",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Classes_trainersID",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "membersID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "membershiptypesID",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "trainersID",
                table: "Classes");
        }
    }
}
