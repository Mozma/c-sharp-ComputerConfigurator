using System.Collections.Generic;
using System.Linq;
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
        /// Возвращает объект Детали по полученному имени.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Part getSelectedPart(string name)
        {
            name = name.ToLower();
            for (int i = 0; i < parts.Count; i++)
                if (parts[i].Name.ToLower().Equals(name))
                    return parts[i];

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
                case "meanmax":
                    return tmp[tmp.Count / 2 + tmp.Count / 4];
                case "mean":
                    return tmp[tmp.Count / 2];
                case "minmean":
                    return tmp[tmp.Count / 4];
                case "min":
                    return tmp.First();
                   
            }

            return null;
        }


        /// <summary>
        /// Возвращает полную цену всех деталей по заданному типу цены.
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        public double findFullPrice(string price) 
        { 
            double sum = 0;
            sum += findPrice("Motherboard", price).Price;
            sum += findPrice("Processor",   price).Price;
            sum += findPrice("Memory",      price).Price;
            sum += findPrice("GPU",         price).Price;
            sum += findPrice("Storage",     price).Price;
            sum += findPrice("PSU",         price).Price;
            sum += findPrice("Case",        price).Price;

            return sum;
        }


    }
}
