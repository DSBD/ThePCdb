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
        static public List<Components.RAMPart> RAMLIST { get; set; }
        static public List<Components.CoolingPart> CoolingList { get; set; }
        static public List<Components.CasePart> CaseList { get; set; }
        static public List<Components.StoragePart> StorageList { get; set; }
        static public List<Components.PSUPart> PSUList { get; set; }
        static public List<Components.GPUPart> GPUList { get; set; }
        static Warehouse()
        {
            CPUList = new List<Components.CPUPart>();
            MotherboardList = new List<Components.MotherboardPart>();
            RAMLIST = new List<Components.RAMPart>();
            CoolingList = new List<Components.CoolingPart>();
            CaseList = new List<Components.CasePart>();
            StorageList = new List<Components.StoragePart>();
            PSUList = new List<Components.PSUPart>();
            GPUList = new List<Components.GPUPart>();
            LoadCPU();
            loadMotherboards();
            loadRAM();
            loadCooling();
            loadCase();
            loadStorage();
            loadPSU();
            loadGPU();

        }
        public static void LoadCPU()
        {
            //Intel CPUS
            CPUList.Add(new Components.CPUPart("Intel Core i9-7980XE", 2449.99, 0, "CPU", 18, 2.6, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 3455,"112001"));
            CPUList.Add(new Components.CPUPart("Intel Core i9-7960X", 2079.99, 0, "CPU", 16, 2.8, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 3161, "112002"));
            CPUList.Add(new Components.CPUPart("Intel Core i9-7940X", 1799.99, 0, "CPU", 14, 3.1, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 2849, "112003"));
            CPUList.Add(new Components.CPUPart("Intel Core i9-7920X", 1599.99, 0, "CPU", 12, 2.9, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 2438, "112004"));
            CPUList.Add(new Components.CPUPart("Intel Core i9-7900X", 1259.99, 0, "CPU", 10, 3.3, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 2194, "112005"));
            CPUList.Add(new Components.CPUPart("Intel Core i7-7820X", 764.99, 0, "CPU", 8, 3.6, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 1751, "112006"));
            CPUList.Add(new Components.CPUPart("Intel Core i7-7800X", 514.99, 0, "CPU", 6, 3.5, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Chipset.X299, 1285, "112007"));
            CPUList.Add(new Components.CPUPart("Intel Core i7-8700K", 499.99, 0, "CPU", 6, 3.7, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 1447, "111001"));
            CPUList.Add(new Components.CPUPart("Intel Core i7-8700", 399.99, 0, "CPU", 6, 3.2, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 1434, "111002"));
            CPUList.Add(new Components.CPUPart("Intel Core i5-8600K", 329.99, 0, "CPU", 6, 3.6, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 1040, "111003"));
            CPUList.Add(new Components.CPUPart("Intel Core i5-8600", 299.99, 0, "CPU", 6, 3.1, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 959, "111004"));
            CPUList.Add(new Components.CPUPart("Intel Core i5-8500", 269.99, 0, "CPU", 6, 3.0, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 934, "111005"));
            CPUList.Add(new Components.CPUPart("Intel Core i5-8400", 236.99, 0, "CPU", 6, 2.8, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 954, "111006"));
            CPUList.Add(new Components.CPUPart("Intel Core i3-8350K", 219.99, 0, "CPU", 4, 4.0, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 684, "111007"));
            CPUList.Add(new Components.CPUPart("Intel Core i3-8300", 199.99, 0, "CPU", 4, 3.7, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 633, "111008"));
            CPUList.Add(new Components.CPUPart("Intel Core i3-8100", 144.99, 0, "CPU", 4, 3.6, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 616, "111009"));
            CPUList.Add(new Components.CPUPart("Intel Pentium Gold G5600", 124.99, 0, "CPU", 2, 3.9, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 425, "111010"));
            CPUList.Add(new Components.CPUPart("Intel Pentium Gold G5500", 209.99, 0, "CPU", 2, 3.8, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 414, "111011"));
            CPUList.Add(new Components.CPUPart("Intel Pemtium Gold G5400", 89.99, 0, "CPU", 2, 3.7, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 403, "111012"));
            CPUList.Add(new Components.CPUPart("Intel Celeron G4920", 74.99, 0, "CPU", 2, 3.2, Components.CPUPart.Socket.LGA1151, Components.CPUPart.Chipset.Z370, 243, "111013"));
            //AMD CPUS
            CPUList.Add(new Components.CPUPart("AMD Ryzen 7 1800X", 659.99, 0, "CPU", 8, 3.6, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 1617, "123001"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 7 1700X", 514.99, 0, "CPU", 8, 3.4, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 1532, "123002"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 7 1700", 439.99, 0, "CPU", 8, 3.0, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 1403, "123003"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 1600X", 319.99, 0, "CPU", 6, 3.6, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 1126, "123004"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 1600", 299.99, 0, "CPU", 6, 3.2, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 1094, "123005"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 1500X", 213.99, 0, "CPU", 4, 3.5, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 712, "123006"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 1400", 224.99, 0, "CPU", 4, 3.2, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 731, "123007"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 5 2400G", 209.99, 0, "CPU", 4, 3.6, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 826, "123008"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 3 1200", 139.99, 0, "CPU", 4, 3.1, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 477, "123009"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 3 1300X", 169.99, 0, "CPU", 4, 3.5, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 553, "123010"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen 3 2200G", 129.99, 0, "CPU", 4, 3.5, Components.CPUPart.Socket.AM4, Components.CPUPart.Chipset.X370, 576, "123011"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen Threadripper 1950X", 1399.99, 0, "CPU", 16, 3.4, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399, 2986, "124001"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen Threadripper 1920X", 1199.99, 0, "CPU", 12, 3.5, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399, 2433, "124002"));
            CPUList.Add(new Components.CPUPart("AMD Ryzen Threadripper 1900X", 799.99, 0, "CPU", 8, 3.8, Components.CPUPart.Socket.sTR4, Components.CPUPart.Chipset.X399, 1709, "124003"));
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
            //END OF MOTHERBOARD
        }
        public static void loadRAM()
        {
            RAMLIST.Add(new Components.RAMPart("Corsair Vengeance LPX 8GB (2 x 4GB)", 144.99, 0, "RAM", "511001", "DDR4", 8, 3000));
            RAMLIST.Add(new Components.RAMPart("Corsair Dominator Platinum 8GB (2 x 4GB)", 292.99, 0, "RAM", "511002", "DDR4", 8, 4000));
            RAMLIST.Add(new Components.RAMPart("Corsair Dominator Platinum 16GB ROG Sig", 329.99, 0, "RAM", "512001", "DDR4", 16, 3200));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence LPX 16GB (4 x 4)", 289.99, 0, "RAM", "512002", "DDR4", 16, 3000));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence LPX 16GB (2 x 8)", 269.99, 0, "RAM", "513001", "DDR4", 16, 3200));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence LED 16GB (2 x 8)", 264.99, 0, "RAM", "513002", "DDR4", 16, 3000));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence RGB 16GB (2 x 8)", 275.99, 0, "RAM", "513003", "DDR4", 16, 3200));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence LPX 32GB (4 x 8)", 489.99, 0, "RAM", "514001", "DDR4", 32, 2666));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence LED 32GB (4 x 8)", 519.99, 0, "RAM", "514002", "DDR4", 32, 3000));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence RGB 32GB (4 x 8)", 549.99, 0, "RAM", "514003", "DDR4", 32, 3200));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence LPX 64GB (8 x 8)", 1049.99, 0, "RAM", "515001", "DDR4", 64, 2666));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence RGB 64GB (8 x 8)", 1019.99, 0, "RAM", "515002", "DDR4", 64, 2666));
            RAMLIST.Add(new Components.RAMPart("Corsair Dominator Platinum 64GB (8 x 8)", 1299.99, 0, "RAM", "515003", "DDR4", 64, 3000));
            RAMLIST.Add(new Components.RAMPart("Corsair Dominator Platinum 32GB (2 x 16)", 529.99, 0, "RAM", "516001", "DDR4", 32, 3000));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence LPX 32GB (2 x 16)", 559.99, 0, "RAM", "516002", "DDR4", 32, 4000));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence RGB 32GB (2 x 16)", 549.99, 0, "RAM", "516003", "DDR4", 32, 3200));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence LED 32GB (2 x 16)", 519.99, 0, "RAM", "516004", "DDR4", 32, 3000));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence RGB 64GB (4 x 16)",979.99, 0, "RAM", "517001", "DDR4", 64, 2666));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengence RGB 64GB (4 x 16)", 1119.99, 0, "RAM", "517002", "DDR4", 64, 3200));
            RAMLIST.Add(new Components.RAMPart("Corsair Dominator Platinum 128GB (8 x 16)", 2279.99, 0, "RAM", "518001", "DDR4", 128, 3200));
            RAMLIST.Add(new Components.RAMPart("Corsair Vengeance RGB 128GB (8 x 16)", 2219.99, 0, "RAM", "518002", "DDR4", 128, 3600));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ Series 8GB (2 x 4)", 145.99, 0, "RAM", "521001", "DDR4", 8, 3000));
            RAMLIST.Add(new Components.RAMPart("G.Skill Ripjaws V Series 8GB (2 x 4)", 148.99, 0, "RAM", "521002", "DDR4", 8, 3600));
            RAMLIST.Add(new Components.RAMPart("G.Skill Aegis 8GB (2 x 4)", 111.99, 0, "RAM", "521003", "DDR4", 8, 2400));
            RAMLIST.Add(new Components.RAMPart("G.Skill Ripjaws V Series 16GB (4 x 4)", 272.99, 0, "RAM", "522001", "DDR4", 16, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill Ripjaws 4 Series 16GB (4 x 4)", 236.99, 0, "RAM", "522002", "DDR4", 16, 2666));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ Series 16GB (4 x 4)", 296.99, 0, "RAM", "522003", "DDR4", 16, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill Ripjaws V Series 16GB (2 x 8)", 232.99, 0, "RAM", "523001", "DDR4", 16, 3000));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ RGB Series 16GB (2 x 8)", 262.99, 0, "RAM", "523002", "DDR4", 16, 3000));
            RAMLIST.Add(new Components.RAMPart("G.Skill Flare X Series 16GB (2 x 8)", 306.99, 0, "RAM", "523003", "DDR4", 16, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ RGB Series 32GB (4 x 8)", 524.99, 0, "RAM", "524001", "DDR4", 32, 3000));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ Series 32GB (4 x 8)", 749.99, 0, "RAM", "524002", "DDR4", 32, 4000));
            RAMLIST.Add(new Components.RAMPart("G.Skill Flare X Series 32GB (4 x 8)", 609.99, 0, "RAM", "524003", "DDR4", 32, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ RGB Series 64GB (8 x 8)", 1499.99, 0, "RAM", "525001", "DDR4", 64, 3733));
            RAMLIST.Add(new Components.RAMPart("G.Skill Ripjaws V Series 64GB (8 x 8)", 1059.99, 0, "RAM", "525002", "DDR4", 64, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ Series 64GB (8 x 8)", 1139.99, 0, "RAM", "525003", "DDR4", 64, 3000));
            RAMLIST.Add(new Components.RAMPart("G.Skill Ripjaws V Series 32GB (2 x 16)", 455.99, 0, "RAM", "526001", "DDR4", 32, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ Series 32GB (2 x 16)", 574.99, 0, "RAM", "526002", "DDR4", 32, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ RGB Series 64GB (4 x 16)", 1269.99, 0, "RAM", "527001", "DDR4", 64, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill Rpijaws V Series 64GB (4 x 16)", 909.99, 0, "RAM", "527002", "DDR4", 64, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ RGB Series 128GB (8 x 16)", 2549.99, 0, "RAM", "528001", "DDR4", 128, 3200));
            RAMLIST.Add(new Components.RAMPart("G.Skill TridentZ Series 128GB (8 x 16)", 1879.99, 0, "RAM", "528002", "DDR4", 128, 3200));
            RAMLIST.Add(new Components.RAMPart("Team T-Force Vulcan 8GB (2 x 4)", 120.99, 0, "RAM", "531001", "DDR4", 8, 3000));
            RAMLIST.Add(new Components.RAMPart("Team T-Force Delta II RGB Series 8GB (2 x 4)", 128.99, 0, "RAM", "531002", "DDR4", 8, 3000));
            RAMLIST.Add(new Components.RAMPart("Team T-Force Delta II RGB Series 16GB (2 x 8)", 222.99, 0, "RAM", "533001", "DDR4", 16, 2400));
            RAMLIST.Add(new Components.RAMPart("Team T-Force DARK 16GB (2 x 8)", 222.99, 0, "RAM", "533002", "DDR4", 16, 3000));
            RAMLIST.Add(new Components.RAMPart("Team T-Force Vulcan 16GB (2 x 8)", 214.99, 0, "RAM", "533003", "DDR4", 16, 3000));
            //END OF Ram list
        }
        public static void loadCooling()
        {
            CoolingList.Add(new Components.CoolingPart("Cooler Master RR-HD92-28PK-R1", 57.99, 0, "Cooling", "711001", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4}));
            CoolingList.Add(new Components.CoolingPart("Cooler Master Hyper 212 EVO", 44.99, 0, "Cooling", "711002", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master Hyper 212 LED", 49.99, 0, "Cooling", "711003", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master Hyper 212X", 59.99, 0, "Cooling", "711004", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterAirMA410P RGB", 44.99, 0, "Cooling", "711005", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterAir MA610P", 54.99, 0, "Cooling", "711006", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterAir Maker 8", 179.99, 0, "Cooling", "711007", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterAir MA620P", 79.99, 0, "Cooling", "711008", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterLiqUid ML240R", 159.99, 0, "Cooling", "712001", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterLiquid lite 240", 75.99, 0, "Cooling", "712002", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterLiquid lite ML240L RGB", 84.99, 0, "Cooling", "712003", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterLiquid Lite ML120L RGB", 79.99, 0, "Cooling", "7120043", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master MasterLiquid ML120R", 129.99, 0, "Cooling", "712005", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master HydroSeries H100i V2", 149.99, 0, "Cooling", "722001", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master HydroSeries H150i PRO RGB", 214.99, 0, "Cooling", "722002", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Cooler Master HydroSeries H115i PRO RGB", 179.99, 0, "Cooling", "722003", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Fractal Design Celsius S24", 159.99, 0, "Cooling", "732001", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4, Components.CPUPart.Socket.sTR4}));
            CoolingList.Add(new Components.CoolingPart("NZXT Kraken X62", 219.99, 0, "Cooling", "742001", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4, Components.CPUPart.Socket.sTR4 }));
            CoolingList.Add(new Components.CoolingPart("NZXT Kraken X52", 189.99, 0, "Cooling", "742002", "AIO", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4, Components.CPUPart.Socket.sTR4 }));
            CoolingList.Add(new Components.CoolingPart("Noctua NH-U95", 69.99, 0, "Cooling", "751001", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Noctua NH-D15 SSo2 D-Type", 99.99, 0, "Cooling", "751002", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Noctua NH-U12S", 84.99, 0, "Cooling", "751003", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.LGA1151, Components.CPUPart.Socket.LGA2066, Components.CPUPart.Socket.AM4 }));
            CoolingList.Add(new Components.CoolingPart("Noctua NH-U9 TR4-SP3", 89.99, 0, "Cooling", "751004", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.sTR4 }));
            CoolingList.Add(new Components.CoolingPart("Noctua NH-U14S TR4-Sp3", 99.99, 0, "Cooling", "751005", "Air", new List<Components.CPUPart.Socket> { Components.CPUPart.Socket.sTR4 }));
            //END OF COOLINg
        }
        public static void loadCase()
        {
            CaseList.Add(new Components.CasePart("NZXT S349 Elite Matte White Steal", 139.99, 0, "Case", "611001", "ATX", 5, 7, true, true, true));
            CaseList.Add(new Components.CasePart("NZXT S340 Elite Matte Black Steal", 99.99, 0, "Case", "611002", "ATX", 4, 7, true, true, true));
            CaseList.Add(new Components.CasePart("NZXT S340 Elite Glossy White Steal", 99.99, 0, "Case", "611003", "ATX", 4, 7, true, true, true));
            CaseList.Add(new Components.CasePart("NZXT S340 Elite Matte Black Steal", 139.99, 0, "Case", "611004", "ATX", 5, 7, true, true, true));
            CaseList.Add(new Components.CasePart("NZXT Noctis 450", 189.99, 0, "Case", "621005", "ATX", 8, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Fractal Design Meshify C - TG", 119.99, 0, "Case", "611005", "ATX", 5, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Fractal Design Meshify C Black", 119.99, 0, "Case", "621001", "ATX", 5, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Fractal Design Focis G", 74.99, 0, "Case", "621002", "ATX", 3, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Fractal Design Define R6 Black", 199.99, 0, "Case", "621003", "EATX", 8, 9, true, true, true));
            CaseList.Add(new Components.CasePart("Fractal Design Define R6 Blackout", 199.99, 0, "Case", "621004", "EATX", 8, 9, true, true, true));
            CaseList.Add(new Components.CasePart("Cooler Master MasterBox Lite 5 RGB", 89.99, 0, "Case", "631001", "ATX", 3, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Cooler Master MasterBox Lite 3.1", 59.99, 0, "Case", "633001", "mATX", 3, 4, true, true, true));
            CaseList.Add(new Components.CasePart("Cooler Master MasterCase H500P", 199.99, 0, "Case", "631002", "EATX", 4, 9, true, true, true));
            CaseList.Add(new Components.CasePart("Cooler Master MasterCaae H500P Mesh White", 194.99, 0, "Case", "631003", "EATX", 4, 9, true, true, true));
            CaseList.Add(new Components.CasePart("Cooler Master MasterBox 5 Black", 99.99, 0, "Case", "631004", "ATX", 3, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Cooler Master N400 NSE", 79.99, 0, "Case", "631005", "EATX", 10, 7, false, false, true));
            CaseList.Add(new Components.CasePart("Corsair Crystal 570X White", 229.99, 0, "Case", "641001", "ATX", 4, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Corsair Crystal Series 570X Black", 229.99, 0, "Case", "641002", "ATX", 4, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Corsair Obsidian 500D", 184.99, 0, "Case", "641003", "ATX", 5, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Corsair Carbide Series 275R", 99.99, 0, "Case", "641004", "ATX", 4, 7, true, true, true));
            CaseList.Add(new Components.CasePart("Corsair Carbide series SPEC-OMEGA", 128.99, 0, "Case", "641005", "ATX", 4, 7, true, true, true));
            // END OF CASES
        }
        public static void loadStorage()
        {
            StorageList.Add(new Components.StoragePart("WD Blue 3D NAND 250GB PC SSD", 105.99, 0, "Storage", "811001", "SSD", 250, "2.5", "SATA"));
            StorageList.Add(new Components.StoragePart("WD Blue 3D NAND 500GB PC SSD", 169.99, 0, "Storage", "811002", "SSD", 500, "2.5", "SATA"));
            StorageList.Add(new Components.StoragePart("WD Blue 3D NAND 1TB PC SSD", 449.99, 0, "Storage", "811003", "SSD", 1000, "2.5", "SATA"));
            StorageList.Add(new Components.StoragePart("WD Blue 3D NAND 2TB PC SSD", 640.99, 0, "Storage", "811004", "SSD", 2000, "2.5", "SATA"));
            StorageList.Add(new Components.StoragePart("WD Blue 3D NAND 250GB PC SSD M.2", 105.99, 0, "Storage", "811005", "SSD", 250, "SATA M.2", "M.2"));
            StorageList.Add(new Components.StoragePart("WD Blue 3D NAND 500GB PC SSD M.2", 169.99, 0, "Storage", "811006", "SSD", 500, "SATA M.2", "M.2"));
            StorageList.Add(new Components.StoragePart("WD Blue 3D NAND 1TB PC SSD M.2", 349.99, 0, "Storage", "811007", "SSD", 1000, "SATA M.2", "M.2"));
            StorageList.Add(new Components.StoragePart("WD Blue 3D NAND 2TB PC SSD M.2", 749.99, 0, "Storage", "811008", "SSD", 2000, "SATA M.2", "M.2"));
            StorageList.Add(new Components.StoragePart("WD Black 500GB", 89.99, 0, "Storage", "812001", "HDD", 500, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("WD Black 1TB", 109.99, 0, "Storage", "812002", "HDD", 1000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("WD Black 2TB", 179.99, 0, "Storage", "812003", "HDD", 2000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("WD Black 4TB", 263.99, 0, "Storage", "812004", "HDD", 4000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("WD Black 6TB", 349.99, 0, "Storage", "812005", "HDD", 6000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("Seagate BarraCuda ST500DM009", 69.99, 0, "Storage", "821001", "HDD", 500, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("Seagate BarraCuda ST1000DM010", 99.99, 0, "Storage", "821002", "HDD", 1000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("Seagate BarraCuda ST2000DM006", 89.99, 0, "Storage", "821003", "HDD", 2000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("Seagate BarraCuda ST3000DM008", 139.99, 0, "Storage", "821004", "HDD", 3000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("Seagate BarraCuda ST4000DM004", 159.99, 0, "Storage", "821005", "HDD", 4000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("Seagate BarraCuda ST6000DM003", 219.99, 0, "Storage", "821006", "HDD", 6000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("Seagate BarraCuda ST8000DM004", 277.99, 0, "Storage", "821007", "HDD", 8000, "3.5", "SATA"));
            StorageList.Add(new Components.StoragePart("Samsung 960 PRO M.2 512GB", 429.99, 0, "Storage", "831001", "SSD", 512, "NVMe", "M.2 2280"));
            StorageList.Add(new Components.StoragePart("Samsung 960 PRO M.2 1TB", 793.99, 0, "Storage", "831002", "SSD", 1000, "NVMe", "M.2 2280"));
            StorageList.Add(new Components.StoragePart("Samsung 960 PRO M.2 2TB", 1649.99, 0, "Storage", "831003", "SSD", 2000, "NVMe", "M.2 2280"));
            StorageList.Add(new Components.StoragePart("Samsung 960 EVO M.2 512GB", 201.99, 0, "Storage", "831004", "SSD", 512, "NVMe", "M.2 2280"));
            StorageList.Add(new Components.StoragePart("Samsung 960 EVO M.2 1TB", 376.99, 0, "Storage", "831005", "SSD", 1000, "NVMe", " M.22280"));
            StorageList.Add(new Components.StoragePart("Samsung 960 EVO M.2 2TB", 589.99, 0, "Storage", "831006", "SSD", 2000, "NVMe", " M.22280"));
            StorageList.Add(new Components.StoragePart("Corsair Force MP500 M.2 2280 120GB", 109.99, 0, "Storage", "841001", "SSD", 120, "NVMe", "M.2 2280"));
            StorageList.Add(new Components.StoragePart("Corsair Force MP500 M.2 2280 240GB", 169.99, 0, "Storage", "841002", "SSD", 240, "NVMe", "M.2 2280"));
            StorageList.Add(new Components.StoragePart("Corsair Force MP500 M.2 2280 480GB", 329.99, 0, "Storage", "841003", "SSD", 480, "NVMe", "M.2 2280"));
            StorageList.Add(new Components.StoragePart("Corsair Force MP500 M.2 2280 960GB", 699.99, 0, "Storage", "841004", "SSD", 960, "NVMe", "M.2 2280"));
            StorageList.Add(new Components.StoragePart("Corsair Force MP500 M.2 2280 400GB", 419.99, 0, "Storage", "841005", "SSD", 400, "NVMe", "PCIe"));
            StorageList.Add(new Components.StoragePart("Corsair Force MP500 M.2 2280 800GB", 899.99, 0, "Storage", "841006", "SSD", 800, "NVMe", "PCIe"));
            // END OF STORAGE
        }
        public static void loadPSU()
        {
            PSUList.Add(new Components.PSUPart("Corsair CX-M Series CX550W 80 Plus BRONZE", 89.99, 0, "PSU", "411001", "ATX", 550, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("Corsair CX-M Series CX650W 80 Plus BRONZE", 99.99, 0, "PSU", "411002", "ATX", 50, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("Corsair CX750M 80 Plus BRONZE", 124.99, 0, "PSU", "411003", "ATX", 750, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("Corsair CX850M 80 Plus BRONZE", 149.99, 0, "PSU", "411004", "ATX", 850, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("Corsair CX-M RMx Series RM750x", 149.99, 0, "PSU", "412001", "ATX", 750, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("Corsair CX-M RMx Series RM850x", 164.99, 0, "PSU", "412002", "ATX", 850, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("Corsair SF Series SF450", 114.99, 0, "PSU", "412003", "ATX", 450, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("Corsair SF Series SF600", 179.99, 0, "PSU", "412004", "ATX", 600, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("Corsair HX Series HX750", 174.99, 0, "PSU", "413001", "ATX", 750, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("Corsair HX Series HX850", 214.99, 0, "PSU", "413001", "ATX", 850, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("Corsair HX Series HX1000", 264.99, 0, "PSU", "413001", "ATX", 1000, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("Corsair HX Series HX1200", 309.99, 0, "PSU", "413001", "ATX", 1200, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("Corsair AXi Series AX860i", 284.99, 0, "PSU", "413001", "ATX", 860, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("Corsair AXi Series HX1200i", 439.99, 0, "PSU", "413001", "ATX", 1200, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("Corsair Axi Series HAX1600", 639.99, 0, "PSU", "414001", "ATX", 1600, Components.PSUPart.EightyPlus.Titanium));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V550", 79.99, 0, "PSU", "421001", "SFX", 550, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V650", 89.99, 0, "PSU", "421002", "SFX", 650, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V750", 99.99, 0, "PSU", "421003", "ATX", 750, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V650", 169.99, 0, "PSU", "422001", "ATX", 650, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V750", 199.99, 0, "PSU", "422002", "ATX", 750, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V850", 232.99, 0, "PSU", "422003", "ATX", 850, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V1000", 319.99, 0, "PSU", "422004", "ATX", 1000, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V1200 Platinum", 399.99, 0, "PSU", "423001", "ATX", 1200, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("Cooler Master Master V1200 MIJ", 1399.99, 0, "PSU", "424001", "ATX", 1200, Components.PSUPart.EightyPlus.Titanium));
            PSUList.Add(new Components.PSUPart("EVGA 550 B3", 89.99, 0, "PSU", "431001", "ATX", 550, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("EVGA 650 B3", 109.99, 0, "PSU", "431002", "ATX", 650, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("EVGA 750 B3", 114.99, 0, "PSU", "431003", "ATX", 750, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("EVGA 850 B3", 149.99, 0, "PSU", "431004", "ATX", 850, Components.PSUPart.EightyPlus.Bronze));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 650 G3", 164.99, 0, "PSU", "432001", "ATX", 650, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 750 G3", 179.99, 0, "PSU", "432002", "ATX", 750, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 850 G3", 209.99, 0, "PSU", "432003", "ATX", 850, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 1000 G3", 299.99, 0, "PSU", "432004", "ATX", 1000, Components.PSUPart.EightyPlus.Gold));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 750 P2", 209.99, 0, "PSU", "433001", "ATX", 750, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 850 P2", 306.99, 0, "PSU", "433002", "ATX", 850, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 1000 P2", 352.99, 0, "PSU", "433003", "ATX", 1000, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 1200 P2", 479.99, 0, "PSU", "433004", "ATX", 1200, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 1600 P2", 579.99, 0, "PSU", "433005", "ATX", 1600, Components.PSUPart.EightyPlus.Platinum));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 750 T2", 387.99, 0, "PSU", "434001", "ATX", 750, Components.PSUPart.EightyPlus.Titanium));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 850 T2", 349.99, 0, "PSU", "434002", "ATX", 850, Components.PSUPart.EightyPlus.Titanium));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 1000 T2", 459.99, 0, "PSU", "434003", "ATX", 1000, Components.PSUPart.EightyPlus.Titanium));
            PSUList.Add(new Components.PSUPart("EVGA SuperNOVA 1600 T2", 664.99, 0, "PSU", "434004", "ATX", 1600, Components.PSUPart.EightyPlus.Titanium));
            //LOAD PSU
        }
        public static void loadGPU()
        {
            GPUList.Add(new Components.GPUPart("Asus GeForce GT 1030 2GB", 162.99, 0, "GPU", "310001", 1278, 1531, 2, 245));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1080Ti Strix", 1419.99, 0, "GPU", "311001", 1597, 1708, 11, 5655));
            GPUList.Add(new Components.GPUPart("Asus ROG Strix Radeon RX 560", 209.99, 0, "GPU", "311101", 1149, 1197, 4, 907));
            GPUList.Add(new Components.GPUPart("Asus Radeon RX 560 EVO", 219.99, 0, "GPU", "311102", 1149, 1197, 4, 907));
            GPUList.Add(new Components.GPUPart("Asus ROG Radeon RX Vega 64 STRIX", 1269.99, 0, "GPU", "311201", 1590, 1590, 8, 3662));
            GPUList.Add(new Components.GPUPart("Asus ROG Radeon RX Vega 56 STRIX", 1084.99, 0, "GPU", "311301", 1297, 1573, 8, 3502));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1080 STRIX", 1049.99, 0, "GPU", "312001", 1695, 1835, 8, 4152));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1070Ti STRIX", 864.99, 0, "GPU", "313001", 1683, 1759, 8, 3153));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1070Ti Cerberus", 819.99, 0, "GPU", "313002", 1607, 1746, 8, 3153));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1070 STRIX", 779.99, 0, "GPU", "314001", 1607, 1746, 8, 3153));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1070 STRIX", 779.99, 0, "GPU", "314001", 1607, 1746, 8, 3153));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1060 STRIX", 519.99, 0, "GPU", "315001", 1645, 1873, 6, 2645));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1060 3GB", 379.99, 0, "GPU", "315003", 1645, 1873, 3, 2604));
            GPUList.Add(new Components.GPUPart("Asus ROG GeForce GTX 1050Ti STRIX", 329.99, 0, "GPU", "316001", 1392, 1506, 4, 1522));
            GPUList.Add(new Components.GPUPart("AsusGeForce GTX 1050Ti CERBERUS", 269.99, 0, "GPU", "365003", 1392, 1506, 4, 1522));
            GPUList.Add(new Components.GPUPart("Asus  GeForce GTX 1050 CERBERUS", 247.99, 0, "GPU", "317001", 1404, 1518, 4, 1522));
            GPUList.Add(new Components.GPUPart("Asus ROG Strix Radeon RX 580", 569.99, 0, "GPU", "318001", 1380, 1380, 8, 3579));
            GPUList.Add(new Components.GPUPart("Gigabyte GTX 1080Ti Gaming", 1299.99, 0, "GPU", "321001", 1544, 1544, 11, 5418));
            GPUList.Add(new Components.GPUPart("Gigabyte GTX 1080 G1 Gaming", 799.99, 0, "GPU", "322001", 1721, 1860, 8, 3831));
            GPUList.Add(new Components.GPUPart("Gigabyte GTX 1070 TI AORUS", 774.99, 0, "GPU", "323001", 1607, 1771, 8, 3513));
            GPUList.Add(new Components.GPUPart("Gigabyte GTX 1070", 624.99, 0, "GPU", "324001", 1632, 1860, 8, 3483));
            GPUList.Add(new Components.GPUPart("Gigabyte GTX 1060 Mini 6G", 409.99, 0, "GPU", "325003", 1645, 1873, 6, 2604));
            GPUList.Add(new Components.GPUPart("Gigabyte GTX 1060 AORUS", 514.99, 0, "GPU", "325004", 1645, 1873, 6, 2604));
            GPUList.Add(new Components.GPUPart("Gigabyte GTX 1050 TI OC", 298.99, 0, "GPU", "326001", 1392, 1506, 4, 1522));
            GPUList.Add(new Components.GPUPart("Gigabyte GTX 1050 Gaming 2G", 272.99, 0, "GPU", "327001", 1404, 1518, 4, 941));
            GPUList.Add(new Components.GPUPart("Gigabyte AORUS Radeon RX 580", 454.99, 0, "GPU", "328001", 1380, 1380, 8, 3579));
            GPUList.Add(new Components.GPUPart("Gigabyte AORUS Radeon RX 570", 394.99, 0, "GPU", "329002", 1295, 1295, 8, 2159));
            GPUList.Add(new Components.GPUPart("MSI GeForce GT 1030 Aero", 137.99, 0, "GPU", "330001", 1278, 1531, 2, 244));
            GPUList.Add(new Components.GPUPart("MSI GTX 1080Ti", 1272.99, 0, "GPU", "331001", 1569, 1569, 11, 5375));
            GPUList.Add(new Components.GPUPart("MSI Radeon RX 560 Aero", 294.74, 0, "GPU", "331101", 1149, 1197, 4, 907));
            GPUList.Add(new Components.GPUPart("MSI Radeon RX Vega 56", 884.99, 0, "GPU", "331301", 1297, 1573, 8, 3506));
            GPUList.Add(new Components.GPUPart("MSI GeFore GTX 1080 DUKE", 834.99, 0, "GPU", "332003", 1708, 1847, 8, 3565));
            GPUList.Add(new Components.GPUPart("MSI GeFore GTX 1070 Armor", 736.99, 0, "GPU", "333004", 1607, 1683, 8, 3513));
            GPUList.Add(new Components.GPUPart("MSI GeFore GTX 1070 Aero ITX", 899.99, 0, "GPU", "334002", 1632, 1860, 8, 3438));
            GPUList.Add(new Components.GPUPart("MSI GeFore GTX 1060 ARMOR 6G", 575.99, 0, "GPU", "335004", 1645, 1873, 6, 2604));
            GPUList.Add(new Components.GPUPart("MSI GeFore GTX 1050 Ti Gaming X", 304.99, 0, "GPU", "336001", 1392, 1506, 4, 1522));
            GPUList.Add(new Components.GPUPart("MSI GeFore GTX 1050 Aero ITX", 238.99, 0, "GPU", "337002", 1404, 1518, 4, 941));
            GPUList.Add(new Components.GPUPart("MSI Radeon RX 580 ARMOR MK2", 474.99, 0, "GPU", "338001", 1380, 1380, 8, 3579));
            GPUList.Add(new Components.GPUPart("MSI Radeon RX 570 ARMOR MK2", 444.99, 0, "GPU", "339001", 1295, 1295, 8, 2519));
            GPUList.Add(new Components.GPUPart("EVGA GeFore GTX 1080 TI SC2 Hybrid", 1549.99, 0, "GPU", "341003", 1556, 1670, 8, 6444));
            GPUList.Add(new Components.GPUPart("EvGA GeFore GTX 1080 FTW Gaming", 869.99, 0, "GPU", "342002", 1721, 1860, 8, 3565));
            GPUList.Add(new Components.GPUPart("EVGA GeFore GTX 1070 Ti FTW2", 829.99, 0, "GPU", "343002", 1607, 1683, 8, 3513));
            GPUList.Add(new Components.GPUPart("EVGA GeFore GTX 1070 Hybrid Gaming", 751.99, 0, "GPU", "344002", 1632, 1860, 8, 3438));
            GPUList.Add(new Components.GPUPart("EVGA GeFore GTX 1060 FTW+ Gaming", 495.99, 0, "GPU", "345003", 1645, 1832, 6, 2604));
            GPUList.Add(new Components.GPUPart("EVGA GeFore GTX 1050 Ti SSC Gaming", 334.99, 0, "GPU", "346002", 1392, 1506, 4, 1522));
            GPUList.Add(new Components.GPUPart("EVGA GeFore GTX 1050 FTW Gaming", 249.99, 0, "GPU", "347003", 1404, 1518, 4, 941));
        } // Steven reaction to finishing the database (╯°□°）╯︵ ┻━┻
    }
}
