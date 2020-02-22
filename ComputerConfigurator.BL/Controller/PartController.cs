
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComputerConfigurator.BL.Model;
namespace ComputerConfigurator.BL.Controller
{
    public class PartController
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

        /// <summary>
        /// Получение всех деталей нужного типа.
        /// </summary>
        /// <param name="type">Тип.</param>
        /// <returns></returns>
        public List<Part> getAllPartsOfOneType(string type)
        {
            type = type.ToLower();

            List<Part> tmp = new List<Part>(10);

            for (int i = 0; i < parts.Count; i++)
                if (parts[i].Type.ToLower().Equals(type))
                    tmp.Add(parts[i]);

            //parts.FindAll(s => s.Type.Equals("match"));

            return tmp;

        }
        /// <summary>
        /// Метод для нахождения детали с заданым парметром.
        /// </summary>
        /// <param name="type">Тип.</param>
        /// <param name="price">Какая нужна цена.</param>
        /// <returns></returns>
        public  Part findPrice(string type , string price)
        {
            var tmp = getAllPartsOfOneType(type).OrderBy(o => o.Price).ToList();

            switch (price.ToLower())
            {
                case "max":
                    return tmp.Last();
                case "mean":
                    return tmp[tmp.Count / 2];
                case "min":
                    return tmp.First();
                   
            }

            return null;
        }

   
    }
}
