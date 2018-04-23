using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class StoragePart : Part
    {
        public string DriveType { get; set; }
        public int Capacity { get; set; }
        public string FormFactor { get; set; }
        public string InterfaceType { get; set; }

        public StoragePart(string name, double price, int rating, string type, string IPID, string dtype, int capacity, string ffactor, string interfaceType) : base(name, price, rating, type, IPID)
        {
            DriveType = dtype;
            Capacity = capacity;
            FormFactor = ffactor;
            InterfaceType = interfaceType;
        }
    }
}