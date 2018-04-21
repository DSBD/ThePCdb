using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.Components
{
    class CPUPart : Part
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
        public enum ChipsetCompat
        {
            X299,
            Z27,
            X470,
            X399
        }
        protected Socket SocketType { get; set; }
        protected ChipsetCompat ChipsetCompatability { get; set; }
        protected int CineBenchScore { get; set; }

        public CPUPart(string name, double price, int rating, string type, int corecount, double freq, Socket soc, ChipsetCompat chip, int cine, string ID) : base(name, price, rating, type, ID)
        {
            CoreCount = corecount;
            Frequency = freq;
            SocketType = soc;
            ChipsetCompatability = chip;
            CineBenchScore = cine;
        }
    }
}
