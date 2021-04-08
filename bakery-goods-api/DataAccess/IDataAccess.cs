using System.Collections.Generic;
using bakery_goods_api.Models;

namespace bakery_goods_api.DataAccess {
    interface IDataAccess {
        public IEnumerable<BakeryGood> GetBakeryGoods();
    }
}