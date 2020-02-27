using System;


namespace ComputerConfigurator.BL.Model
{
    public class Computer
    {
        #region Свойства   
        /// <summary>
        /// Имя комплектации компьютера.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Желаемая цена комплектации.
        /// </summary>
        public double wantedPrice { get; set; }
        /// <summary>
        /// Общая цена деталей.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Все основные детали компьютера.
        /// </summary>
        public ComputerParts Parts { get; set; } 

        #endregion

        public Computer(string type, double price)
        {
            Name = Guid.NewGuid().ToString().Substring(0,8);
            wantedPrice = price;
            Parts = new ComputerParts();

            Price = Parts.getPrice();
        }

        public override string ToString()
        {
            return $"{Name} - ПК по цене {Price}";
        }
    }
}
