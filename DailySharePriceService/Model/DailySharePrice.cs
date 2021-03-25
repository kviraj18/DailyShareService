using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePriceService.Model
{
    public class DailySharePrice
    {
        public int StockId { get; set; }
        public string StockName { get; set; }
        public double StockValue { get; set; }
    }
}


