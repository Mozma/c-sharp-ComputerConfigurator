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

        /// <summary>
        /// Пересчитывает цену текущего компьютера.
        /// </summary>
        public void update()
        {
            CurrentPC.Price = CurrentPC.Parts.getPrice();
        }


        /// <summary>
        /// Вывод для консоли.
        /// </summary>
        /// <returns></returns>
        public string printFullInfo()
        {
            string result;

            result = String.Format("\t{0} {1}\n", "Корпус:", CurrentPC.Parts.Case.Name) +
                     String.Format("\t{0} {1}\n", "Процессор:", CurrentPC.Parts.Processor.Name) +
                     String.Format("\t{0} {1}\n", "Оперативка:", CurrentPC.Parts.Memory.Name) +
                     String.Format("\t{0} {1}\n", "Материнская плата:", CurrentPC.Parts.Motherboard.Name) +
                     String.Format("\t{0} {1}\n", "GPU:", CurrentPC.Parts.GPU.Name) +
                     String.Format("\t{0} {1}\n", "Память:", CurrentPC.Parts.Storage.Name) +
                     String.Format("\t{0} {1}\n", "Блок питания:", CurrentPC.Parts.PSU.Name);



            return result;
        }

        /// <summary>
        /// Выбор деталей комплекта.
        /// </summary>
        /// <param name="type">Тип сборки</param>
        public void setPreset(string type)
        {
            switch (type.ToLower())
            {
                case "game":
                    setAllPice("max", "max", "max", "max", "max", "max", "max");
                    break;

                case "office":
                    setAllPice("min", "mean", "mean", "mean", "mean", "mean", "min");
                    break;

                case "home":
                    setAllPice("mean", "mean", "max", "mean", "max", "mean", "mean");
                    break;

                case "design":
                    setAllPice("mean", "max", "max", "max", "mean", "max", "mean");
                    break;

                case "task":
                    setAllPice("max", "max", "max", "mean", "max", "mean", "min");
                    break;

                case "forprice":
                    Price pr = new Price();

                    if (CurrentPC.wantedPrice > pr.HighPrice)
                    {
                        setAllPice("max", "max", "max", "max", "max", "max", "max");
                        break;
                    }
                    if (CurrentPC.wantedPrice > pr.MediumHighPrice)
                    {
                        setAllPice("meanMax", "meanMax", "meanMax", "meanMax", "meanMax", "meanMax", "meanMax");
                        break;
                    }
                    if (CurrentPC.wantedPrice > pr.MediumPrice)
                    {
                        setAllPice("mean", "mean", "mean", "mean", "mean", "mean", "mean");
                        break;
                    }
                    if (CurrentPC.wantedPrice > pr.LowMediumPrice)
                    {
                        setAllPice("minMean", "minMean", "minMean", "minMean", "minMean", "minMean", "minMean");
                        break;
                    }
                    if (CurrentPC.wantedPrice > pr.LowPrice)
                    {
                        setAllPice("min", "min", "min", "min", "min", "min", "min");
                        break;
                    }

                    break;
            }
        }

       /// <summary>
       /// Вспомогательный метод для сборки пресетов.
       /// </summary>

        private void setAllPice(string motherboard, string processor, string memory, string gpu, string storage, string psu, string caseValue)
        {
            var parts = new PartController();

            CurrentPC.Parts.Motherboard = parts.findPrice("motherboard", motherboard);
            CurrentPC.Parts.Processor   = parts.findPrice("processor",   processor);
            CurrentPC.Parts.Memory      = parts.findPrice("memory",      memory);
            CurrentPC.Parts.GPU         = parts.findPrice("gpu",         gpu);
            CurrentPC.Parts.Storage     = parts.findPrice("storage",     storage);
            CurrentPC.Parts.PSU         = parts.findPrice("psu",         psu);
            CurrentPC.Parts.Case        = parts.findPrice("case",        caseValue);

            update();
        }


        public override string ToString()
        {
            return CurrentPC.ToString();
        }
    }

}
