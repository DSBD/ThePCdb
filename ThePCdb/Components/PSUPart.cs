using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class PSUPart : Part
    {
        public string FormFactor { get; set; }
        public int Wattage { get; set; }
        public EightyPlus EPRating { get; set; }

        public PSUPart(string name, double price, int rating, string type, string ipid, string ffactor, int wattage, EightyPlus epRating) : base(name, price, rating, type, ipid)
        {
            FormFactor = ffactor;
            Wattage = wattage;
            EPRating = epRating;
        }

        public enum EightyPlus
        {
            Bronze,
            Gold,
            Platinum,
            Titanium,
            Other
        }
    }
}