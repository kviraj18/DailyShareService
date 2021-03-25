using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailySharePriceService.Model;

namespace DailySharePriceService.Repository
{
   public interface IShareRepository
    {
        public double GetShareValue(string StockName);
        //object SingleOrDefault(Func<object, bool> p);
    }
}

