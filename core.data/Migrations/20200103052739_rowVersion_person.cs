using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace core.data.Migrations
{
    public partial class rowVersion_person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Remark",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Relative",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "People",
                rowVersion: true,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Contacts",
                rowVersion: true,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Remark");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Relative");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "People");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Contacts");
        }
    }
}
