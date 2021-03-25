using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailySharePriceService.Repository;
using DailySharePriceService.Services;
using System.Net.Http;
using System.Net;

namespace DailySharePriceService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DailySharePriceController : Controller
    {
        private ISharePriceService _dailySharePriceService;

        public DailySharePriceController(ISharePriceService dailySharePriceService)
        {
            _dailySharePriceService = dailySharePriceService;
        }


        [HttpGet("{stockname}")]
        public ActionResult<double> GetShareValue(string stockname)
        {

            if (stockname == null)
            {
                return this.BadRequest();
            }
            return _dailySharePriceService.GetShareValue(stockname);
        }
    }
}


















