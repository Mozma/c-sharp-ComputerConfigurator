using ComputerConfigurator.BL.Controller;

using System.Collections.Generic;

namespace ComputerConfigurator.BL.Model
{

    /// <summary>
    /// Класс для хранения данных о деталях в сборке ПК.
    /// </summary>
    public class ComputerParts
    {
        public Part Motherboard { get; set; }
        public Part Processor { get; set; }
        public Part Memory { get; set; }
        public Part GPU { get; set; }
        public Part Storage { get; set; }
        public Part PSU { get; set; }
        public Part Case { get; set; }

        public ComputerParts()
        {
            var parts = new PartController();

            Motherboard = parts.getPart("Motherboard");
            Processor   = parts.getPart("Processor");
            Memory      = parts.getPart("Memory");
            GPU         = parts.getPart("GPU");
            Storage     = parts.getPart("Storage");
            PSU         = parts.getPart("PSU");
            Case        = parts.getPart("Case");
        }

    }
}