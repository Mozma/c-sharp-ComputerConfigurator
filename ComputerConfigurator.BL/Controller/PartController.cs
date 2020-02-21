
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComputerConfigurator.BL.Model;
namespace ComputerConfigurator.BL.Controller
{
    class PartController
    {
        public static List<Part> parts { get; set; }

        public PartController()
        {
            if (parts == null)
                parts =  Part.getList();

        }

        /// <summary>
        /// Получение первой детали нужного типа из списка деталей.
        /// </summary>
        /// <param name="type">Тип.</param>
        /// <returns></returns>
        public Part getPart(string type)
        {
            type = type.ToLower();

            for (int i = 0; i < parts.Count; i++)
                if (parts[i].Type.ToLower().Equals(type))
                {
                    return parts[i];
                }

            return null;

        }

    }
}
