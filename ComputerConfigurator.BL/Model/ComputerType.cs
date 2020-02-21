using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerConfigurator.BL.Model
{
    /// <summary>
    /// Тип компьютера. Например: "Игровой","Офисный" и т.д
    /// </summary>
    class ComputerType
    {
        public string Name { get; set; }

        public ComputerType(string type)
        {
            // TODO: проверки

            Name = type;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
