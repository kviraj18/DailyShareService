using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePriceService.Model
{
    public static class DailySharePriceHelper
    {
        public static List<DailySharePrice> shares = new List<DailySharePrice>()
        {
             new DailySharePrice
                {
                    StockId = 001,
                    StockName = "Tesla",
                    StockValue= 50
                },
             new DailySharePrice
                {
                    StockId = 002,
                    StockName = "Facebook",
                    StockValue= 20.09
                },

                 new DailySharePrice
                 {
                     StockId = 003,
                     StockName = "Apple",
                     StockValue= 66
                 },
                  new DailySharePrice
                  {
                     StockId = 004,
                     StockName = "TATA",
                     StockValue= 40.8

                  },
                new DailySharePrice
                  {
                     StockId = 005,
                     StockName = "Cognizant",
                     StockValue= 60

                  }


        };

    }
}




