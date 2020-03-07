using ComputerConfigurator.BL.Controller;

namespace ComputerConfigurator.BL.Model
{
   public class Price
    {
        public double HighPrice { get; set; }
        public double MediumHighPrice { get; set; }
        public double MediumPrice { get; set; }
        public double LowMediumPrice { get; set; }
        public double LowPrice { get; set; }

        PartController parts = new PartController();
        public Price()
        {
            HighPrice       = parts.findFullPrice("max");
            MediumHighPrice = parts.findFullPrice("meanMax");
            MediumPrice     = parts.findFullPrice("mean");
            LowMediumPrice  = parts.findFullPrice("minMean");
            LowPrice        = parts.findFullPrice("min");
        }

    }
}
