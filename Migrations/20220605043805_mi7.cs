using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppTutorial.Migrations
{
    public partial class mi7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Grade",
                table: "Post",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
