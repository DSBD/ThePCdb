using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
   public class GPUPart : Part
    {
        protected int CoreFrequency { get; set; }
        protected int BoostFrequency { get; set; }
        protected int VRAM { get; set; }
        protected int ThreeDMarkScore {get; set; }

        public GPUPart(string name, double price, int rating, string type, string ID,int corefreq, int boost, int vram, int threed):base(name, price, rating, type, ID)
        {
            CoreFrequency = corefreq;
            BoostFrequency = boost;
            VRAM = vram;
            ThreeDMarkScore = threed;
        }
    }
}
