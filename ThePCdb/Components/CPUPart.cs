using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class CPUPart : Part
    {
        public int CoreCount { get; set; }
        public double Frequency { get; set; }
        public enum Socket
        {
           LGA1151,
           LGA2066,
           AM4,
           sTR4
        }
        public enum Chipset
        {
            X299,
            Z370,
            X370,
            X399
        }
        public Socket SocketType { get; set; }
        public Chipset ChipsetCompatability { get; set; }
        public int CineBenchScore { get; set; }

        public CPUPart(string name, double price, int rating, string type, int corecount, double freq, Socket soc, Chipset chip, int cine, string ID) : base(name, price, rating, type, ID)
        {
            CoreCount = corecount;
            Frequency = freq;
            SocketType = soc;
            ChipsetCompatability = chip;
            CineBenchScore = cine;
        }
    }
}
