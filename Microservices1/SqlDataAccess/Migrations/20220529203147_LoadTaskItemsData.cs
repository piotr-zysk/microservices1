using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SqlDataAccess.Migrations
{
    public partial class LoadTaskItemsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO TaskItems (Name, Description, DueDate) VALUES ('task1', 'description1', '2022-05-30 0:00:00'), ('task2', 'description2', '2022-06-29 18:05:00')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
