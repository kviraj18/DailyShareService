using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailySharePriceService.Model;

namespace DailySharePriceService.Repository
{
    public class ShareRepository : IShareRepository
    {
        public double GetShareValue(string stockname)
        {
            var ss = DailySharePriceHelper.shares.SingleOrDefault(p => p.StockName == stockname);
            return ss.StockValue;
                      
        }
    }
}

