using Microsoft.EntityFrameworkCore.Migrations;

namespace PCconfiguration.Migrations
{
    public partial class SeedingRestOfDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cases",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Cooler Master Cosmos C700P", 421.43000000000001 },
                    { 2, "NZXT H710i", 169.99000000000001 },
                    { 3, "NZXT H200i", 99.989999999999995 },
                    { 4, "Nanoxia Deep Silence 3", 80.0 },
                    { 5, "Corsair Carbide 275R", 79.989999999999995 }
                });

            migrationBuilder.InsertData(
                table: "CdDvds",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "ASUS ZenDrive Ultra Slim USB 2.0 External 8X", 36.140000000000001 },
                    { 2, "External DVD Drive Kilineo USB 3.0 CD Burner Reader", 25.989999999999998 },
                    { 3, "Asus Black 12X BD-ROM 16X DVD-ROM 48X CD-ROM SATA Internal Blu-Ray Drive", 58.710000000000001 },
                    { 4, "LG Electronics Internal Super Multi Drive Optical Drives GH24NSC0B", 1000.0 },
                    { 5, "Lite-On 24X SATA Internal DVD+/-RW Drive Optical Drive IHAS124-14", 14.949999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Coolings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "NZXT Kraken X62", 125.98999999999999 },
                    { 3, "be quiet! Dark Rock 4", 74.849999999999994 },
                    { 4, "Corsair H150i", 170.52000000000001 },
                    { 1, "Cooler Master Hyper 212 Evo", 28.699999999999999 },
                    { 2, "Noctua NH-D15", 89.950000000000003 }
                });

            migrationBuilder.InsertData(
                table: "CpuCoolings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Corsair H115i RGB Platinum", 68.0 },
                    { 2, "EVGA CLC 240", 200.0 },
                    { 3, "Cooler Master MA410M", 113.59 },
                    { 4, "Corsair H60 (2018)", 104.34999999999999 },
                    { 5, "Cooler Master MasterLiquid ML360R", 280.0 }
                });

            migrationBuilder.InsertData(
                table: "GraphicsCards",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "NVIDIA Titan RTX", 2499.9899999999998 },
                    { 2, "NVIDIA GeForce RTX 2080 Ti", 1229.95 },
                    { 3, "NVIDIA Titan Xp", 1779.0 },
                    { 4, "NVIDIA GeForce GTX 1080 Ti", 699.87 },
                    { 5, "AMD Radeon VII", 549.99000000000001 }
                });

            migrationBuilder.InsertData(
                table: "HardDrives",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "Samsung 970 Pro", 304.44 },
                    { 4, "WD Black SN750 NVMe SSD", 81.989999999999995 },
                    { 3, "Samsung 970 Evo Plus SSD", 108.0 },
                    { 2, "Toshiba X300", 170.96000000000001 },
                    { 1, "Seagate BarraCuda", 39.939999999999998 }
                });

            migrationBuilder.InsertData(
                table: "Motherboards",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Gigabyte Z390 Designare", 269.99000000000001 },
                    { 2, "ASRock Z390 Phantom Gaming ITX", 179.99000000000001 },
                    { 3, "Gigabyte Z390 Gaming X", 139.99000000000001 },
                    { 4, "ASRock H370M Pro4", 84.989999999999995 },
                    { 5, "Gigabyte X299X Designare 10G", 599.99000000000001 }
                });

            migrationBuilder.InsertData(
                table: "OperatingSystems",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Windows 10 Home", 139.0 },
                    { 2, "Windows 10 Pro", 199.99000000000001 },
                    { 3, "Chalet Operating System", 50.0 },
                    { 4, "Ubuntu OS", 150.0 },
                    { 5, "Linux Mint", 89.989999999999995 }
                });

            migrationBuilder.InsertData(
                table: "PowerSupplies",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 5, "Corsair AX1000", 269.98000000000002 },
                    { 4, "Corsair AX850", 239.99000000000001 },
                    { 2, "Seasonic SSR-600TL", 242.43000000000001 },
                    { 1, "Bitfenix BF450G", 60.0 },
                    { 3, "Seasonic SSR-750PX", 148.99000000000001 }
                });

            migrationBuilder.InsertData(
                table: "Rams",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "CORSAIR VENGEANCE LED 16GB (2x8GB) DDR4 3000MHz C15 Desktop Memory - Blue LED", 179.99000000000001 },
                    { 2, "G.SKILL TridentZ RGB Series 16GB (2 x 8GB) 288-Pin DDR4 3000MHz (PC4 24000)", 89.989999999999995 },
                    { 3, "Kingston Technology ValueRAM 16GB 2400MHz DDR4 ECC CL17 DIMM 2Rx8", 138.99000000000001 },
                    { 4, "4Gb 1866Mhz Ddr3 Cl10 Hyperx Fury Series 2 Pack", 74.370000000000005 },
                    { 5, "Corsair Dominator Platinum RGB 32GB (4x8GB) DDR4 3200 (PC4-25600)", 229.99000000000001 }
                });

            migrationBuilder.InsertData(
                table: "SoundCards",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 4, "ASUS XONAR SE 5.1 Channel 192kHz/24-bit Hi-Res 116dB SNR PCIe Gaming Sound Card", 72.650000000000006 },
                    { 1, "Creative Sound Blaster Audigy PCIe RX 7.1 Sound Card with High Performance Headphone Amp", 300.0 },
                    { 2, "ASUS Sound Card Essence STX II", 106.0 },
                    { 3, "Creative 70SB174000000 Sound BlasterX AE-5 Hi-Resolution PCIe Gaming Sound Card", 238.99000000000001 },
                    { 5, "FiiO E10K USB DAC and Headphone Amplifier (Black)", 144.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cases",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CdDvds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CdDvds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CdDvds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CdDvds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CdDvds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Coolings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CpuCoolings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CpuCoolings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CpuCoolings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CpuCoolings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CpuCoolings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GraphicsCards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HardDrives",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HardDrives",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HardDrives",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HardDrives",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HardDrives",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Motherboards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperatingSystems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PowerSupplies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SoundCards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SoundCards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SoundCards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SoundCards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SoundCards",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
