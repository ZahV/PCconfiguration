using Microsoft.EntityFrameworkCore.Migrations;

namespace PCconfiguration.Migrations
{
    public partial class SeedingProcessorTabble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Processors",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "AMD RYZEN 9 3950X", 750.0 },
                    { 2, "INTEL CORE I9-7980XE", 1225.3399999999999 },
                    { 3, "INTEL CORE I9-9980XE", 2406.7199999999998 },
                    { 4, "AMD RYZEN THREADRIPPER 3960X", 1564.75 },
                    { 5, "INTEL CORE I9-9900KS", 1129.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Processors",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
