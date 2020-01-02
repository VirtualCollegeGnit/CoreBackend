using Microsoft.EntityFrameworkCore.Migrations;

namespace core.data.Migrations
{
    public partial class relation_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "State",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Relative",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Relative_PersonID",
                table: "Relative",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Relative_People_PersonID",
                table: "Relative",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relative_People_PersonID",
                table: "Relative");

            migrationBuilder.DropIndex(
                name: "IX_Relative_PersonID",
                table: "Relative");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Relative");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "State",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
