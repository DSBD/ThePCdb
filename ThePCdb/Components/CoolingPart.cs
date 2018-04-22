using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class CoolingPart : Part
    {
        protected string CoolerType { get; set; }
        public List<CPUPart.Socket> Compatability { get; set; }

        public CoolingPart(string name, double price, int rating, string type, string ipid, string ctype, List<CPUPart.Socket> compList) : base(name, price, rating, type, ipid)
        {
            CoolerType = ctype;
            Compatability = compList;
        }
    }
}