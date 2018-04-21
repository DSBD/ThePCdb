using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class StoragePart : Part
    {
        protected string DriveType { get; set; }
        protected int Capacity { get; set; }
        protected string FormFactor { get; set; }
        protected string InterfaceType { get; set; }

        public StoragePart(string name, double price, int rating, string type, string IPID, string dtype, int capacity, string ffactor, string interfaceType) : base(name, price, rating, type, IPID)
        {
            DriveType = dtype;
            Capacity = capacity;
            FormFactor = ffactor;
            InterfaceType = interfaceType;
        }
    }
}