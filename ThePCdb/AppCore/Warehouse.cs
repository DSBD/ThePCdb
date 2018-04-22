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
        static public List<Components.MotherboardPart> MotherboardList { get; set; }
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
        public static void loadMotherboards()
        {
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Rampage VI Extreme", 810.92, 0, "Motherboard", "212001","ATX",8,4,true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("MSI X299 Gaming Pro Carbon AC", 630.96, 0, "Motherboard", "222001", "ATX", 8, 4, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("MSI X299 Gaming M7 ACK", 682.27, 0, "Motherboard", "222002", "ATX", 8, 4, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Asus Prime X299 Deluxe", 596.99, 0, "Motherboard", "212002", "ATX", 8, 3, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte AORUS Gaming 7", 596.99, 0, "Motherboard", "232001", "ATX", 8, 5, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Asus WS X299 PRO/SE", 514.99, 0, "Motherboard", "21200", "EATX", 8, 4, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Strix X299-XE Gaming", 474.99, 0, "Motherboard", "212002", "ATX", 8, 4, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Strix X299-E Gaming", 439.99, 0, "Motherboard", "212002", "ATX", 8, 3, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Asus Prime X299-A", 394.99, 0, "Motherboard", "212006", "ATX", 8, 3, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Asus TUF X299 MARK 2", 334.99, 0, "Motherboard", "212007", "ATX", 8, 3, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("MSI X299 SLI Plus", 312.99, 0, "Motherboard", "222003", "ATX", 8, 4, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte X299 UD4", 309.99, 0, "Motherboard", "232002", "ATX", 8, 5, true, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Maximus X Extreme", 624.99, 0, "Motherboard", "211001", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Maximus X Formula", 569.99, 0, "Motherboard", "211002", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Maximus X Apex", 498.99, 0, "Motherboard", "211003", "EATX", 2, 4, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Maximus X Code", 369.99, 0, "Motherboard", "211004", "ATX", 4, 2, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Maximus X Hero", 324.99, 0, "Motherboard", "211005", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus Prime Z370-A", 319.02, 0, "Motherboard", "211006", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Maximus X Hero (Wifi)", 349.99, 0, "Motherboard", "211007", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Strix Z730-E Gaming", 259.99, 0, "Motherboard", "211008", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Strix Z730-F Gaming", 243.99, 0, "Motherboard", "211009", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Strix Z730-H Gaming", 209.99, 0, "Motherboard", "211010", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("MSI Z370 Gaming Pro Carbon AC", 264.99, 0, "Motherboard", "231001", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("MSI Z370 Gaming M5", 243.99, 0, "Motherboard", "231002", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("MSI Z370 Gaming Pro Carbon", 229.99, 0, "Motherboard", "231003", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("MSI Z370 KRAIT Gaming", 204.99, 0, "Motherboard", "231004", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("MSI Z370 Tomahowk", 190.50, 0, "Motherboard", "231005", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("MSI Z370 SLI Plus", 189.99, 0, "Motherboard", "231006", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte Z730 AORUS Gaming 7", 298.99, 0, "Motherboard", "221001", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte Z730 AORUS Gaming 5", 233.99, 0, "Motherboard", "221001", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte Z730 AORUS Ultra Gaming", 214.99, 0, "Motherboard", "221001", "ATX", 4, 3, true, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Zenith Extreme sTR4", 661.99, 0, "Motherboard", "214001", "EATX", 8, 4, true, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Strix X399-E", 499.99, 0, "Motherboard", "214002", "EATX", 8, 3, true, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399));
            MotherboardList.Add(new Components.MotherboardPart("Asus Prime X399-A sTR4", 533.99, 0, "Motherboard", "214003", "EATX", 8, 4, true, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399));
            MotherboardList.Add(new Components.MotherboardPart("MSI X399 Gaming Pro Carbon AC sTR4", 489.99, 0, "Motherboard", "234001", "ATX", 8, 4, true, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399));
            MotherboardList.Add(new Components.MotherboardPart("MSI X399 SLI Plus sTR4", 439.99, 0, "Motherboard", "234002", "ATX", 8, 4, true, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte X399 AORUS Gaming 7 sTR4", 499.9, 0, "Motherboard", "234001", "ATX", 8, 5, true, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte X399 Designare EX sTR4", 514.99, 0, "Motherboard", "234002", "ATX", 8, 5, true, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399));
            MotherboardList.Add(new Components.MotherboardPart("MSI X370 Gaming Pro Carbon AM4", 249.99, 0, "Motherboard", "233001", "ATX", 8, 4, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("MSI X370 Gaming Plus AM4", 173.99, 0, "Motherboard", "233002", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("MSI X370 Gaming Pro AM4", 194.99, 0, "Motherboard", "233003", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("MSI X370 Gaming M7 ACK AM4", 309.99, 0, "Motherboard", "233004", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("MSI KRAIT Gaming AM4", 184.99, 0, "Motherboard", "233001", "ATX", 8, 5, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("MSI X370 SLI PLus", 164.99, 0, "Motherboard", "233006", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("MSI X370 XPOWER Gaming Titanium AM4", 374.99, 0, "Motherboard", "233007", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Crosshait VI HERO", 329.99, 0, "Motherboard", "213001", "ATX", 8, 4, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Strix X370-F Gaming", 239.99, 0, "Motherboard", "213002", "ATX", 8, 4, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Asus Prime X370-Pro", 197.99, 0, "Motherboard", "213003", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Crosshair VI Hero (Wifi)", 328.99, 0, "Motherboard", "213004", "ATX", 8, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Asus ROG Crosshair VI Extreme ", 444.99, 0, "Motherboard", "213005", "ATX", 8, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Asus Prime X370-A", 159.99, 0, "Motherboard", "213006", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte GA-AX370 Gaming 5 AM4", 334.99, 0, "Motherboard", "223001", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte GA-AX370 Gaming K5 AM4", 242.99, 0, "Motherboard", "223002", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
            MotherboardList.Add(new Components.MotherboardPart("Gigabyte AORUS GA-AX370 Gaming K7", 259.99, 0, "Motherboard", "223003", "ATX", 4, 3, true, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370));
        }
    }
}
