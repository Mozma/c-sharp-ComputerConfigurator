using ComputerConfigurator.BL.Controller;
using ComputerConfigurator.BL.Model;
using System;


namespace ComputerConfigurator.CMD
{
    /// <summary>
    /// Для тестирования функций программы.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Собран ПК:");
            ComputerController computer = new ComputerController("Игровой", 50000);
            Console.WriteLine(computer.printFullInfo());


            PartController pc = new PartController();
            
            
            foreach(var part in pc.getAllPartsOfOneType("gpu"))
                Console.WriteLine(part.Name.ToString());
        
            
            Console.ReadLine();
        }
    }
}
