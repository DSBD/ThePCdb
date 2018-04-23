using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class RAMPart : Part
    {
        public string RAMType { get; set; }
        public int Capacity { get; set; }
        public int Frequency { get; set; }
        public RAMPart(string name, double price, int rating, string type, string ID, string ramt, int cap, int freq) : base(name, price, rating, type, ID)
        {
            RAMType = ramt;
            Capacity = cap;
            Frequency = freq;

        }
    }
}