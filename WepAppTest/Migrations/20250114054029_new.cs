using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WepAppTest.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                comment: "20 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "20 simvoldan cox ola bilmez");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                comment: "20 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "20 simvoldan cox ola bilmez");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Doctors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                comment: "10 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "10 simvoldan cox ola bilmez");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Doctors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                comment: "10 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldComment: "10 simvoldan cox ola bilmez");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                comment: "20 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "20 simvoldan cox ola bilmez");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "20 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "20 simvoldan cox ola bilmez");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "20 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "20 simvoldan cox ola bilmez");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Doctors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                comment: "10 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldComment: "10 simvoldan cox ola bilmez");

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Doctors",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                comment: "10 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true,
                oldComment: "10 simvoldan cox ola bilmez");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "20 simvoldan cox ola bilmez",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true,
                oldComment: "20 simvoldan cox ola bilmez");
        }
    }
}
