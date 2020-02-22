using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerConfigurator.BL.Model
{
    /// <summary>
    /// Класс для хранения информации о комплектующих ПК.
    /// </summary>
    public class Part
    {
        /// <summary>
        /// Тип детали.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Название детали.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Цена детали.
        /// </summary>
        public double Price { get; set; }

        public static List<Part> parts = new List<Part>();

        public Part()
        {
            if(parts == null)
                createNewData();
        }

        public Part(string type, string name, double price)
        {
            Type = type;
            Name = name;
            Price = price;
        }


        public static List<Part> getList()
        {
            if (parts.Count < 1)
                createNewData();
            
            return parts;
        }

        private static void createNewData()
        {
            parts.Add(new Part("Motherboard", "MSI H110M PRO-VD",  5632));
            parts.Add(new Part("Motherboard", "ASUS PRIME Z390-A", 13360));
            parts.Add(new Part("Motherboard", "ASRock B250M Pro4", 4100));
            parts.Add(new Part("Motherboard", "ASUS X99-E WS",     21682));

            parts.Add(new Part("Processor", "Intel® Core™ i7-9700F", 23800));
            parts.Add(new Part("Processor", "Intel Core i3-6300",    10000));
            parts.Add(new Part("Processor", "AMD Ryzen 3 2200G",     6000));
            parts.Add(new Part("Processor", "Intel Pentium G5400",   3700));

            parts.Add(new Part("GPU", "GeForce RTX 2060",    23500));
            parts.Add(new Part("GPU", "GeForce GTX 1050 Ti", 9500));
            parts.Add(new Part("GPU", "GeForce RTX 2080 Ti", 77500));
            parts.Add(new Part("GPU", "AMD RX 560",          5500));
            
            parts.Add(new Part("Memory", "KINGSTON HyperX FURY DD4 2x8Gb",   7700));
            parts.Add(new Part("Memory", "CRUCIAL CT8G4DFS8266 DDR4 8Gb",    2400));
            parts.Add(new Part("Memory", "Kingston HyperX Predator DD4 8Gb", 3280));
            parts.Add(new Part("Memory", "Crucial CT4G4SFS824A 4 Gb ",       1900));
            
            parts.Add(new Part("Storage", "SEAGATE Barracuda  2 TB HDD", 4190));
            parts.Add(new Part("Storage", "Western Digital Caviar 1Tb",  2000));
            parts.Add(new Part("Storage", "A400 SATA SSD 240 GB",        2800));
            parts.Add(new Part("Storage", "CRUCIAL BX500 SSD 480GB",     5090));

            parts.Add(new Part("PSU", "Cooler Master V750 750W",            6000));
            parts.Add(new Part("PSU", "Cooler Master MasterWatt Lite 700W", 3800));
            parts.Add(new Part("PSU", "500W ExeGate",                       1500));
            parts.Add(new Part("PSU", "Gamdias KRATOS E1-500",              2250));

            parts.Add(new Part("Case", "Дизайнерский", 3400));
            parts.Add(new Part("Case", "Офисный",      1200));
            parts.Add(new Part("Case", "Для геймеров", 4500));
            parts.Add(new Part("Case", "Со стразами",  3500));

        }
    }
}
