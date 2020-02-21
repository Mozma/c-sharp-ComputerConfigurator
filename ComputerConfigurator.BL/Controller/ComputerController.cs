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



        public override string ToString()
        {
            return CurrentPC.ToString();
        }
    }

}
