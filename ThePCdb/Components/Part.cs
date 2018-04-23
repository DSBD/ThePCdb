using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class Part
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Rating { get; set; }
        public string Type { get; set; }
        public string InternalPartID { get; set; }

        public Part(string name, double price, int rating, string type, string IPID)
        {
            Name = name;
            Price = price;
            Rating = rating;
            Type = type;
            InternalPartID = IPID;
        }
    }
}