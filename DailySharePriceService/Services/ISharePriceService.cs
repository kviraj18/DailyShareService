using DailySharePriceService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePriceService.Services
{
    public interface ISharePriceService
    {
        public double GetShareValue(string StockName);
    }
}
