using DailySharePriceService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailySharePriceService.Services
{
    public class SharePriceService : ISharePriceService
    {
        private IShareRepository Repository;

        public SharePriceService(IShareRepository _repository)
        {
            Repository = _repository;
        }

        public double GetShareValue(string StockName)
        {
            return Repository.GetShareValue(StockName);
        }
    }
}
