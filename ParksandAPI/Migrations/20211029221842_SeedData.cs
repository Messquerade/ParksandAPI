using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksandAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Acreage", "Activities", "Address", "Name", "NationalPark", "StatePark" },
                values: new object[,]
                {
                    { 1, 316, "hiking, lake access, swimming, historic buildings, playground", "14445 Juanita Dr NE, Kenmore, WA 98028", "Saint Edward State Park", false, true },
                    { 2, 534, "hiking, beach access, historic lighthouse", "3801 Discovery Park Blvd, Seattle, WA 98199", "Discovery Park", false, false },
                    { 3, 236381, "hiking, mountain climbing, camping", "39000 State Route 706 E, Ashford, WA 98304", "Mount Rainier", true, false },
                    { 4, 350, "walking trails, sports fields, lake access, boating, swimming, off-leash dog area, playground", "7400 Sand Point Way NE, Seattle, WA 98115", "Warren G. Magnuson Park", false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);
        }
    }
}
