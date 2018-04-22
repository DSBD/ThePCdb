using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePCdb.AppCore
{
    public static class Warehouse
    {

        //TODO: Store All Components
        //TODO: Program to Access Component Details by Category
        //TODO: Methods for Each Component

        static public List<Components.CPUPart> CPUList { get; set; }
        static Warehouse()
        {

        }
        public static void LoadCPU()
        {
            //Intel CPUS
            CPUList.Add(new Components.CPUPart("Intel Core i9-7980XE", 2449.99, 0, "CPU", 18, 2.6, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 0,"112001"));
            CPUList.Add(new Components.CPUPart("Intel Core i9-7960X", 2079.99, 0, "CPU", 16, 2.8, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 0, "112002"));
            CPUList.Add(new Components.CPUPart("Intel Core i9-7940X", 1799.99, 0, "CPU", 14, 3.1, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 0, "112003"));
            CPUList.Add(new Components.CPUPart("Intel Core i9-7920X", 1599.99, 0, "CPU", 12, 2.9, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 0, "112004"));
            CPUList.Add(new Components.CPUPart("Intel Core i9-7900X", 1259.99, 0, "CPU", 10, 3.3, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 0, "112005"));
            CPUList.Add(new Components.CPUPart("Intel Core i7-7820X", 764.99, 0, "CPU", 8, 3.6, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 0, "112006"));
            CPUList.Add(new Components.CPUPart("Intel Core i7-7800X", 514.99, 0, "CPU", 6, 3.5, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 0, "112007"));
            CPUList.Add(new Components.CPUPart("Intel Core i7-8700K", 499.99, 0, "CPU", 6, 3.7, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111001"));
            CPUList.Add(new Components.CPUPart("Intel Core i7-8700", 399.99, 0, "CPU", 6, 3.2, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111002"));
            CPUList.Add(new Components.CPUPart("Intel Core i5-8600K", 329.99, 0, "CPU", 6, 3.6, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111003"));
            CPUList.Add(new Components.CPUPart("Intel Core i5-8600", 299.99, 0, "CPU", 6, 3.1, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111004"));
            CPUList.Add(new Components.CPUPart("Intel Core i5-8500", 269.99, 0, "CPU", 6, 3.0, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111005"));
            CPUList.Add(new Components.CPUPart("Intel Core i5-8400", 236.99, 0, "CPU", 6, 2.8, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111006"));
            CPUList.Add(new Components.CPUPart("Intel Core i3-8350K", 219.99, 0, "CPU", 4, 4.0, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111007"));
            CPUList.Add(new Components.CPUPart("Intel Core i3-8300", 199.99, 0, "CPU", 4, 3.7, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111008"));
            CPUList.Add(new Components.CPUPart("Intel Core i3-8100", 144.99, 0, "CPU", 4, 3.6, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111009"));
            CPUList.Add(new Components.CPUPart("Intel Pentium Gold G5600", 124.99, 0, "CPU", 2, 3.9, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111010"));
            CPUList.Add(new Components.CPUPart("Intel Pentium Gold G5500", 209.99, 0, "CPU", 2, 3.8, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111011"));
            CPUList.Add(new Components.CPUPart("Intel Pemtium Gold G5400", 89.99, 0, "CPU", 2, 3.7, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111012"));
            CPUList.Add(new Components.CPUPart("Intel Celeron G4920", 74.99, 0, "CPU", 2, 3.2, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 0, "111013"));
            //AMD CPUS
            CPUList.Add(new Components.CPUPart("AMD Ryzen 7 1800X", 659.99, 0, "CPU", 8, 3.6, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123001"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 7 1700X", 514.99, 0, "CPU", 8, 3.4, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123002"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 7 1700", 439.99, 0, "CPU", 8, 3.0, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123003"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 1600X", 319.99, 0, "CPU", 6, 3.6, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123004"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 1600", 299.99, 0, "CPU", 6, 3.2, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123005"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 1500X", 213.99, 0, "CPU", 4, 3.5, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123006"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 1400", 224.99, 0, "CPU", 4, 3.2, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123007"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 2400G", 209.99, 0, "CPU", 4, 3.6, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123008"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 3 1200", 139.99, 0, "CPU", 4, 3.1, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123009"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 3 1300X", 169.99, 0, "CPU", 4, 3.5, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123010"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 3 2200G", 129.99, 0, "CPU", 4, 3.5, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 0, "123011"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen Threadripper 1950X", 1399.99, 0, "CPU", 16, 3.4, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399, 0, "124001"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen Threadripper 1920X", 1199.99, 0, "CPU", 12, 3.5, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399, 0, "124002"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen Threadripper 1900X", 799.99, 0, "CPU", 8, 3.8, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399, 0, "124003"));
            //END OF CPU LIST

            //Remember to ADD MANUFACTURER TO THE PART NAME DURING CREATION AS IT"S NOT SEPRATE LIKE IN THE SPREADSHEET
        }
    }
}
