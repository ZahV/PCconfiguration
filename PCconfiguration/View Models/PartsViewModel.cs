using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PCconfiguration.Models;
using OperatingSystem = PCconfiguration.Models.OperatingSystem;

namespace PCconfiguration.View_Models
{
    public class PartsViewModel
    {
        public IEnumerable<CdDvd> CdDvds { get; set; }

        public IEnumerable<Cooling> Coolings { get; set; }

        public IEnumerable<CpuCooling> CpuCoolings { get; set; }

        public IEnumerable<GraphicsCard> GraphicsCards { get; set; }

        public IEnumerable<HardDrive> HardDrives { get; set; }

        public IEnumerable<Motherboard> Motherboards { get; set; }

        public IEnumerable<OperatingSystem> OperatingSystems { get; set; }

        public IEnumerable<Processor> Processors { get; set; }

        public IEnumerable<Ram> Rams { get; set; }

        public IEnumerable<Case> Cases { get; set; }

        public IEnumerable<PowerSupply> PowerSupplies { get; set; }

        public IEnumerable<SoundCard> SoundCards { get; set; }




    }
}
