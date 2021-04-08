using System.Collections.Generic;
using bakery_goods_api.Models;

namespace bakery_goods_api.DataAccess {
    public class MockDataAccess : IDataAccess
    {
        public IEnumerable<BakeryGood> GetBakeryGoods()
        {
            var goods = new List<BakeryGood>();
            goods.Add(new BakeryGood(1, "Bread", "Fresh from the oven."));
            goods.Add(new BakeryGood(2, "Sweet Roll", "Sweet and glazed pastry."));
            goods.Add(new BakeryGood(3, "Sourdough", "Fresh from the oven."));
            return goods.ToArray();
        }
    }
}