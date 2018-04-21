using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    public class CPUPart : Part
    {
        protected int CoreCount { get; set; }
        protected double Frequency { get; set; }
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
            Z27,
            X470,
            X399
        }
        public Socket SocketType { get; set; }
        public Chipset ChipsetCompatability { get; set; }
        protected int CineBenchScore { get; set; }

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
