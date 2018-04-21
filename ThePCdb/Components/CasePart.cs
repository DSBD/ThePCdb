using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class CasePart : Part
    {
        protected string FormFactor { get; set; }
        protected int DriveBays { get; set; }
        protected int PCISlots { get; set; }
        protected bool Window { get; set; }
        protected bool LightingCompatability { get; set; }
        protected bool AirFilters { get; set; }

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
