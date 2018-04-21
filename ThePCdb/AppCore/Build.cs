using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.AppCore
{
    public class Build
    {
        protected Components.CasePart Case { get; set; }
        protected Components.CoolingPart Cooling { get; set; }
        protected Components.CPUPart CPU { get; set; }
        protected Components.GPUPart GPU { get; set; }
        protected Components.MotherboardPart Motherboard { get; set; }
        protected Components.PSUPart PSU { get; set; }
        protected Components.RAMPart RAMKit { get; set; }
        protected Components.StoragePart Storage { get; set; }
        public Build(Components.CasePart _case, Components.CoolingPart cooling, Components.CPUPart cpu, Components.GPUPart gpu, Components.MotherboardPart motherboard, Components.PSUPart psu, Components.RAMPart ram, Components.StoragePart storage)
        {
            Case = _case;
            Cooling = cooling;
            CPU = cpu;
            GPU = gpu;
            Motherboard = motherboard;
            PSU = psu;
            RAMKit = ram;
            Storage = storage;
        }
    }
}
