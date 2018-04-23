using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class CasePart : Part
    {
        public string FormFactor { get; set; }
        public int DriveBays { get; set; }
        public int PCISlots { get; set; }
        public bool Window { get; set; }
        public bool LightingCompatability { get; set; }
        public bool AirFilters { get; set; }

        public CasePart(string name, double price, int rating, string type, string ipid, string fFactor, int driveBays, int pciSlots, bool window, bool lightComp, bool aFilters) : base(name, price, rating, type, ipid)
        {
            FormFactor = fFactor;
            DriveBays = driveBays;
            PCISlots = pciSlots;
            Window = window;
            LightingCompatability = lightComp;
            AirFilters = aFilters;
        }
    }
}
