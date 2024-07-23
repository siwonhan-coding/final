using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_Management_System.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentNumber",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentNumber",
                table: "Students");
        }
    }
}
