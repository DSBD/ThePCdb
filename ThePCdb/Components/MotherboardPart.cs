using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class MotherboardPart : Part
    {
        public string FormFactor { get; set; }
        public int RamSlot { get; set; }
        public int PCIeSlots { get; set; }
        public bool OverClockable { get; set; }
        public CPUPart.Socket Socket { get; set; }
        public CPUPart.Chipset chipSetCompatibility { get; set; }

        public MotherboardPart(string name, double price, int rating, string type, string ID, string form, int ram, int pci, bool overclock, CPUPart.Socket soc, CPUPart.Chipset chip) : base(name, price, rating, type, ID)
        {
            FormFactor = form;
            RamSlot = ram;
            PCIeSlots = pci;
            OverClockable = overclock;
            Socket = soc;
            chipSetCompatibility = chip;
        }
    }
}
