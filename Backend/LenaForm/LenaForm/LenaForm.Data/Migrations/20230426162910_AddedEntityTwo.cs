using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LenaForm.Data.Migrations
{
    public partial class AddedEntityTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fields_Forms_Formid",
                table: "Fields");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Forms",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Forms",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "createdBy",
                table: "Forms",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Forms",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Forms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "required",
                table: "Fields",
                newName: "Required");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Fields",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "dataType",
                table: "Fields",
                newName: "DataType");

            migrationBuilder.RenameColumn(
                name: "Formid",
                table: "Fields",
                newName: "FormId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Fields",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Fields_Formid",
                table: "Fields",
                newName: "IX_Fields_FormId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Forms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FormId",
                table: "Fields",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_Forms_FormId",
                table: "Fields",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fields_Forms_FormId",
                table: "Fields");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Forms",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Forms",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Forms",
                newName: "createdBy");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Forms",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Forms",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Required",
                table: "Fields",
                newName: "required");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Fields",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "FormId",
                table: "Fields",
                newName: "Formid");

            migrationBuilder.RenameColumn(
                name: "DataType",
                table: "Fields",
                newName: "dataType");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fields",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Fields_FormId",
                table: "Fields",
                newName: "IX_Fields_Formid");

            migrationBuilder.AlterColumn<string>(
                name: "createdAt",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Formid",
                table: "Fields",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Fields_Forms_Formid",
                table: "Fields",
                column: "Formid",
                principalTable: "Forms",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
