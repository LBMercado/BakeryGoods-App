using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bakery_goods_api.DataAccess;
using bakery_goods_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bakery_goods_api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BakeryGoodController : ControllerBase
    {
        private readonly MockDataAccess _dataContext;

        public BakeryGoodController()
        {
            
            _dataContext = new MockDataAccess();
        }

        [HttpGet]
        public IEnumerable<BakeryGood> Get()
        {
            return _dataContext.GetBakeryGoods();
        }
    }
}
