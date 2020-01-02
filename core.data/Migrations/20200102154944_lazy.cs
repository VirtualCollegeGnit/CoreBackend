using Microsoft.EntityFrameworkCore.Migrations;

namespace core.data.Migrations
{
    public partial class lazy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remark_Members_GivenByID",
                table: "Remark");

            migrationBuilder.DropForeignKey(
                name: "FK_Remark_People_PersonID",
                table: "Remark");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Remark",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GivenByID",
                table: "Remark",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Remark_Members_GivenByID",
                table: "Remark",
                column: "GivenByID",
                principalTable: "Members",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Remark_People_PersonID",
                table: "Remark",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remark_Members_GivenByID",
                table: "Remark");

            migrationBuilder.DropForeignKey(
                name: "FK_Remark_People_PersonID",
                table: "Remark");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Remark",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GivenByID",
                table: "Remark",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Remark_Members_GivenByID",
                table: "Remark",
                column: "GivenByID",
                principalTable: "Members",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remark_People_PersonID",
                table: "Remark",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
