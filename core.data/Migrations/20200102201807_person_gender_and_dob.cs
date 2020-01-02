using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace core.data.Migrations
{
    public partial class person_gender_and_dob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relative_People_PersonID",
                table: "Relative");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Relative",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "People",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Relative_People_PersonID",
                table: "Relative",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relative_People_PersonID",
                table: "Relative");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "PersonID",
                table: "Relative",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Relative_People_PersonID",
                table: "Relative",
                column: "PersonID",
                principalTable: "People",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
