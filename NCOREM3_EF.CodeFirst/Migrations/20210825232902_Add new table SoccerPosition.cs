using Microsoft.EntityFrameworkCore.Migrations;

namespace NCOREM3_EF.CodeFirst.Migrations
{
    public partial class AddnewtableSoccerPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Person",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FullName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Person", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "SoccerPosition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoccerPosition", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Person");

            migrationBuilder.DropTable(
                name: "SoccerPosition");
        }
    }
}
