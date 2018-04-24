using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.AppCore
{
    public class Build
    {
        public Components.CasePart Case { get; set; }
        public Components.CoolingPart Cooling { get; set; }
        public Components.CPUPart CPU { get; set; }
        public Components.GPUPart GPU { get; set; }
        public Components.MotherboardPart Motherboard { get; set; }
        public Components.PSUPart PSU { get; set; }
        public Components.RAMPart RAMKit { get; set; }
        public Components.StoragePart Storage { get; set; }
        public double Price { get; set; }

        public Build()
        {

        }
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
            Price = Case.Price + Cooling.Price + CPU.Price + GPU.Price + Motherboard.Price + PSU.Price + RAMKit.Price + Storage.Price;
        }
    }
}
