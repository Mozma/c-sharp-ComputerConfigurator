using ComputerConfigurator.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerConfigurator.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Собран ПК:");
            ComputerController computer = new ComputerController("Игровой", 50000);
            Console.WriteLine(computer.printFullInfo());
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
