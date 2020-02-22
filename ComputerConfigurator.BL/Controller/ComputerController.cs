using System;
using ComputerConfigurator.BL.Model;

namespace ComputerConfigurator.BL.Controller
{
    /// <summary>
    /// Класс описания основных методов компьютера.
    /// </summary>
    public class ComputerController
    {
        /// <summary>
        /// Конкретный ПК в зависимости от сборки и цены.
        /// </summary>
        public Computer CurrentPC { get; set; }

        public ComputerController(string type, double price)
        {
            CurrentPC = new Computer(type, price);
        }


        public string printFullInfo()
        {
            string result;


            result = $"\tКорпус:           \t{CurrentPC.Parts.Case.Name} - "        + String.Format("{0:C}", CurrentPC.Parts.Case.Price)        + "\n" +
                     $"\tПроцессор:        \t{CurrentPC.Parts.Processor.Name} - "   + String.Format("{0:C}", CurrentPC.Parts.Processor.Price)   + "\n" +
                     $"\tОперативка:       \t{CurrentPC.Parts.Memory.Name} - "      + String.Format("{0:C}", CurrentPC.Parts.Memory.Price)      + "\n" +
                     $"\tМатеринская плата:\t{CurrentPC.Parts.Motherboard.Name} - " + String.Format("{0:C}", CurrentPC.Parts.Motherboard.Price) + "\n" +
                     $"\tGPU:              \t{CurrentPC.Parts.GPU.Name} - "         + String.Format("{0:C}", CurrentPC.Parts.GPU.Price)         + "\n" +
                     $"\tПамять:           \t{CurrentPC.Parts.Storage.Name} - "     + String.Format("{0:C}", CurrentPC.Parts.Storage.Price)     + "\n" +
                     $"\tБлок питания:     \t{CurrentPC.Parts.PSU.Name} - "         + String.Format("{0:C}", CurrentPC.Parts.PSU.Price)         + "\n";

                
            return result;
        }

        public void setPreset(string type)
        {
            var parts = new PartController();

            switch (type.ToLower())
            {
                case "game":
                    CurrentPC.Parts.Motherboard = parts.findPrice("motherboard", "Max");
                    CurrentPC.Parts.Processor   = parts.findPrice("processor",   "Max");
                    CurrentPC.Parts.Memory      = parts.findPrice("memory",      "Max");
                    CurrentPC.Parts.GPU         = parts.findPrice("gpu",         "Max");
                    CurrentPC.Parts.Storage     = parts.findPrice("storage",     "Max");
                    CurrentPC.Parts.PSU         = parts.findPrice("psu",         "Max");
                    CurrentPC.Parts.Case        = parts.findPrice("case",        "Max");

                    break;
                case "office":
                    CurrentPC.Parts.Motherboard = parts.findPrice("motherboard", "Max");
                    CurrentPC.Parts.Processor = parts.findPrice("processor",     "Mean");
                    CurrentPC.Parts.Memory = parts.findPrice("memory",           "Max");
                    CurrentPC.Parts.GPU = parts.findPrice("gpu",                 "min");
                    CurrentPC.Parts.Storage = parts.findPrice("storage",         "Max");
                    CurrentPC.Parts.PSU = parts.findPrice("psu",                 "Max");
                    CurrentPC.Parts.Case = parts.findPrice("case",               "mean");
                    break;
                case "office":
                    CurrentPC.Parts.Motherboard = parts.findPrice("motherboard", "Max");
                    CurrentPC.Parts.Processor = parts.findPrice("processor", "Mean");
                    CurrentPC.Parts.Memory = parts.findPrice("memory", "Max");
                    CurrentPC.Parts.GPU = parts.findPrice("gpu", "min");
                    CurrentPC.Parts.Storage = parts.findPrice("storage", "Max");
                    CurrentPC.Parts.PSU = parts.findPrice("psu", "Max");
                    CurrentPC.Parts.Case = parts.findPrice("case", "mean");
                    break;
                case "office":
                    CurrentPC.Parts.Motherboard = parts.findPrice("motherboard", "Max");
                    CurrentPC.Parts.Processor = parts.findPrice("processor", "Mean");
                    CurrentPC.Parts.Memory = parts.findPrice("memory", "Max");
                    CurrentPC.Parts.GPU = parts.findPrice("gpu", "min");
                    CurrentPC.Parts.Storage = parts.findPrice("storage", "Max");
                    CurrentPC.Parts.PSU = parts.findPrice("psu", "Max");
                    CurrentPC.Parts.Case = parts.findPrice("case", "mean");
                    break;
                case "office":
                    CurrentPC.Parts.Motherboard = parts.findPrice("motherboard", "Max");
                    CurrentPC.Parts.Processor = parts.findPrice("processor", "Mean");
                    CurrentPC.Parts.Memory = parts.findPrice("memory", "Max");
                    CurrentPC.Parts.GPU = parts.findPrice("gpu", "min");
                    CurrentPC.Parts.Storage = parts.findPrice("storage", "Max");
                    CurrentPC.Parts.PSU = parts.findPrice("psu", "Max");
                    CurrentPC.Parts.Case = parts.findPrice("case", "mean");D
                    break;
            }
        }




        //public void changePart(string type, string name)
        //{
        //    switch (type.ToLower())
        //    {
        //       // case "motherboard":
        //         //   CurrentPC.Parts.Motherboard = changePartTo(name);
        //           // break;

        //        //case "processor":
        //        //    processorComboBox.Items.Add(part.Name);
        //        //    break;

        //        //case "memory":
        //        //    memoryComboBox.Items.Add(part.Name);
        //        //    break;

        //        //case "gpu":
        //        //    GPUComboBox.Items.Add(part.Name);
        //        //    break;

        //        //case "storage":
        //        //    storageComboBox.Items.Add(part.Name);
        //        //    break;

        //        //case "psu":
        //        //    PSUComboBox.Items.Add(part.Name);
        //        //    break;

        //        //case "case":
        //        //    caseComboBox.Items.Add(part.Name);
        //        //    break;
        //    }
        //}

        public override string ToString()
        {
            return CurrentPC.ToString();
        }
    }

}
