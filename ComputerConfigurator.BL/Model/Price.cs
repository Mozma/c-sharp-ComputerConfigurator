using ComputerConfigurator.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            LowMediumPrice = parts.findFullPrice("minMean");
            LowPrice        = parts.findFullPrice("min");
        }

        //public Price(double highPrice, double mediumHighPrice, double mediumPrice, double lowMediumhPrice, double lowPrice)
        //{
        //    HighPrice = highPrice;
        //    MediumHighPrice = mediumHighPrice;
        //    MediumPrice = mediumPrice;
        //    LowMediumhPrice = lowMediumhPrice;
        //    LowPrice = lowPrice;
        //}
    }
}
