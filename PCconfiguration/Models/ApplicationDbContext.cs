using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PCconfiguration.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }



        public DbSet<Processor> Processors { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }

        public DbSet<Motherboard> Motherboards { get; set; }

        public DbSet<CdDvd> CdDvds { get; set; }

        public DbSet<Cooling> Coolings { get; set; }

        public DbSet<CpuCooling> CpuCoolings { get; set; }

        public DbSet<HardDrive> HardDrives { get; set; }

        public DbSet<OperatingSystem> OperatingSystems { get; set; }

        public DbSet<Ram> Rams { get; set; }

        public DbSet<SoundCard> SoundCards { get; set; }

        public DbSet<Case> Cases { get; set; }

        public DbSet<PowerSupply> PowerSupplies { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Processor>().HasData(
                new Processor()
                {
                    Id = 1,
                    Name = "AMD RYZEN 9 3950X",
                    Price = 750

                },

                new Processor()
                {
                    Id = 2,
                    Name = "INTEL CORE I9-7980XE",
                    Price = 1225.34

                },

                new Processor()
                {
                    Id = 3,
                    Name = "INTEL CORE I9-9980XE",
                    Price = 2406.72

                },

                new Processor()
                {
                    Id = 4,
                    Name = "AMD RYZEN THREADRIPPER 3960X",
                    Price = 1564.75

                },

                new Processor()
                {
                    Id = 5,
                    Name = "INTEL CORE I9-9900KS",
                    Price = 1129

                }

                );

            modelBuilder.Entity<Case>().HasData(
                new Case()
                {
                    Id = 1,
                    Name = "Cooler Master Cosmos C700P",
                    Price = 421.43

                },

                new Case()
                {
                    Id = 2,
                    Name = "NZXT H710i",
                    Price = 169.99

                },

                new Case()
                {
                    Id = 3,
                    Name = "NZXT H200i",
                    Price = 99.99

                },

                new Case()
                {
                    Id = 4,
                    Name = "Nanoxia Deep Silence 3",
                    Price = 80

                },

                new Case()
                {
                    Id = 5,
                    Name = "Corsair Carbide 275R",
                    Price = 79.99

                }

            );

            modelBuilder.Entity<GraphicsCard>().HasData(
                new GraphicsCard()
                {
                    Id = 1,
                    Name = "NVIDIA Titan RTX",
                    Price = 2499.99

                },

                new GraphicsCard()
                {
                    Id = 2,
                    Name = "NVIDIA GeForce RTX 2080 Ti",
                    Price = 1229.95

                },

                new GraphicsCard()
                {
                    Id = 3,
                    Name = "NVIDIA Titan Xp",
                    Price = 1779

                },

                new GraphicsCard()
                {
                    Id = 4,
                    Name = "NVIDIA GeForce GTX 1080 Ti",
                    Price = 699.87

                },

                new GraphicsCard()
                {
                    Id = 5,
                    Name = "AMD Radeon VII",
                    Price = 549.99

                }

            );

            modelBuilder.Entity<Motherboard>().HasData(
                new Motherboard()
                {
                    Id = 1,
                    Name = "Gigabyte Z390 Designare",
                    Price = 269.99

                },

                new Motherboard()
                {
                    Id = 2,
                    Name = "ASRock Z390 Phantom Gaming ITX",
                    Price = 179.99

                },

                new Motherboard()
                {
                    Id = 3,
                    Name = "Gigabyte Z390 Gaming X",
                    Price = 139.99

                },

                new Motherboard()
                {
                    Id = 4,
                    Name = "ASRock H370M Pro4",
                    Price = 84.99

                },

                new Motherboard()
                {
                    Id = 5,
                    Name = "Gigabyte X299X Designare 10G",
                    Price = 599.99

                }

            );

            modelBuilder.Entity<CdDvd>().HasData(
                new CdDvd()
                {
                    Id = 1,
                    Name = "ASUS ZenDrive Ultra Slim USB 2.0 External 8X",
                    Price = 36.14

                },

                new CdDvd()
                {
                    Id = 2,
                    Name = "External DVD Drive Kilineo USB 3.0 CD Burner Reader",
                    Price = 25.99

                },

                new CdDvd()
                {
                    Id = 3,
                    Name = "Asus Black 12X BD-ROM 16X DVD-ROM 48X CD-ROM SATA Internal Blu-Ray Drive",
                    Price = 58.71

                },

                new CdDvd()
                {
                    Id = 4,
                    Name = "LG Electronics Internal Super Multi Drive Optical Drives GH24NSC0B",
                    Price = 1000

                },

                new CdDvd()
                {
                    Id = 5,
                    Name = "Lite-On 24X SATA Internal DVD+/-RW Drive Optical Drive IHAS124-14",
                    Price = 14.95

                }

            );

            modelBuilder.Entity<Cooling>().HasData(
                new Cooling()
                {
                    Id = 1,
                    Name = "Cooler Master Hyper 212 Evo",
                    Price = 28.70

                },

                new Cooling()
                {
                    Id = 2,
                    Name = "Noctua NH-D15",
                    Price = 89.95

                },

                new Cooling()
                {
                    Id = 3,
                    Name = "be quiet! Dark Rock 4",
                    Price = 74.85

                },

                new Cooling()
                {
                    Id = 4,
                    Name = "Corsair H150i",
                    Price = 170.52

                },

                new Cooling()
                {
                    Id = 5,
                    Name = "NZXT Kraken X62",
                    Price = 125.99

                }

            );

            modelBuilder.Entity<CpuCooling>().HasData(
                new CpuCooling()
                {
                    Id = 1,
                    Name = "Corsair H115i RGB Platinum",
                    Price = 68

                },

                new CpuCooling()
                {
                    Id = 2,
                    Name = "EVGA CLC 240",
                    Price = 200

                },

                new CpuCooling()
                {
                    Id = 3,
                    Name = "Cooler Master MA410M",
                    Price = 113.59

                },

                new CpuCooling()
                {
                    Id = 4,
                    Name = "Corsair H60 (2018)",
                    Price = 104.35

                },

                new CpuCooling()
                {
                    Id = 5,
                    Name = "Cooler Master MasterLiquid ML360R",
                    Price = 280

                }

            );

            modelBuilder.Entity<HardDrive>().HasData(
                new HardDrive()
                {
                    Id = 1,
                    Name = "Seagate BarraCuda",
                    Price = 39.94

                },

                new HardDrive()
                {
                    Id = 2,
                    Name = "Toshiba X300",
                    Price = 170.96

                },

                new HardDrive()
                {
                    Id = 3,
                    Name = "Samsung 970 Evo Plus SSD",
                    Price = 108

                },

                new HardDrive()
                {
                    Id = 4,
                    Name = "WD Black SN750 NVMe SSD",
                    Price = 81.99

                },

                new HardDrive()
                {
                    Id = 5,
                    Name = "Samsung 970 Pro",
                    Price = 304.44

                }

            );

            modelBuilder.Entity<OperatingSystem>().HasData(
                new OperatingSystem()
                {
                    Id = 1,
                    Name = "Windows 10 Home",
                    Price = 139

                },

                new OperatingSystem()
                {

                    Id = 2,
                    Name = "Windows 10 Pro",
                    Price = 199.99

                },

                new OperatingSystem()
                {
                    Id = 3,
                    Name = "Chalet Operating System",
                    Price = 50

                },

                new OperatingSystem()
                {
                    Id = 4,
                    Name = "Ubuntu OS",
                    Price = 150

                },

                new OperatingSystem()
                {
                    Id = 5,
                    Name = "Linux Mint",
                    Price = 89.99

                }

            );

            modelBuilder.Entity<Ram>().HasData(
                new Ram()
                {
                    Id = 1,
                    Name = "CORSAIR VENGEANCE LED 16GB (2x8GB) DDR4 3000MHz C15 Desktop Memory - Blue LED",
                    Price = 179.99

                },

                new Ram()
                {

                    Id = 2,
                    Name = "G.SKILL TridentZ RGB Series 16GB (2 x 8GB) 288-Pin DDR4 3000MHz (PC4 24000)",
                    Price = 89.99

                },

                new Ram()
                {
                    Id = 3,
                    Name = "Kingston Technology ValueRAM 16GB 2400MHz DDR4 ECC CL17 DIMM 2Rx8",
                    Price = 138.99

                },

                new Ram()
                {
                    Id = 4,
                    Name = "4Gb 1866Mhz Ddr3 Cl10 Hyperx Fury Series 2 Pack",
                    Price = 74.37

                },

                new Ram()
                {
                    Id = 5,
                    Name = "Corsair Dominator Platinum RGB 32GB (4x8GB) DDR4 3200 (PC4-25600)",
                    Price = 229.99

                }

            );

            modelBuilder.Entity<SoundCard>().HasData(
                new SoundCard()
                {
                    Id = 1,
                    Name = "Creative Sound Blaster Audigy PCIe RX 7.1 Sound Card with High Performance Headphone Amp",
                    Price = 300

                },

                new SoundCard()
                {

                    Id = 2,
                    Name = "ASUS Sound Card Essence STX II",
                    Price = 106

                },

                new SoundCard()
                {
                    Id = 3,
                    Name = "Creative 70SB174000000 Sound BlasterX AE-5 Hi-Resolution PCIe Gaming Sound Card",
                    Price = 238.99

                },

                new SoundCard()
                {
                    Id = 4,
                    Name = "ASUS XONAR SE 5.1 Channel 192kHz/24-bit Hi-Res 116dB SNR PCIe Gaming Sound Card",
                    Price = 72.65

                },

                new SoundCard()
                {
                    Id = 5,
                    Name = "FiiO E10K USB DAC and Headphone Amplifier (Black)",
                    Price = 144

                }

            );

            modelBuilder.Entity<PowerSupply>().HasData(
                new PowerSupply()
                {
                    Id = 1,
                    Name = "Bitfenix BF450G",
                    Price = 60

                },

                new PowerSupply()
                {

                    Id = 2,
                    Name = "Seasonic SSR-600TL",
                    Price = 242.43

                },

                new PowerSupply()
                {
                    Id = 3,
                    Name = "Seasonic SSR-750PX",
                    Price = 148.99

                },

                new PowerSupply()
                {
                    Id = 4,
                    Name = "Corsair AX850",
                    Price = 239.99

                },

                new PowerSupply()
                {
                    Id = 5,
                    Name = "Corsair AX1000",
                    Price = 269.98

                }

            );


        }
    }


}
