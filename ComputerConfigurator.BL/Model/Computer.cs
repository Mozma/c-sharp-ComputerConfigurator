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
        /// Тип компьютера.
        /// </summary>
        private ComputerType Type { get; set; }
        /// <summary>
        /// Общая цена выбранной комплектации.
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
            Type = new ComputerType(type);
            Price = price;

            Parts = new ComputerParts();
        }



        public override string ToString()
        {
            return $"{Name} - {Type} ПК по цене {Price}";
        }
    }
}
