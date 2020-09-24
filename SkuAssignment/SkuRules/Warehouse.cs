using System;
using System.Collections.Generic;
using System.Text;

namespace SkuAssignment.SkuRules
{
    class Warehouse
    {
        public List<Item> ItemPriceList;

        public Warehouse()
        {
            ItemPriceList = new List<Item>
            {
                new Item {Name = "A", Price = 50.0},
                new Item {Name = "B", Price = 30.0},
                new Item {Name = "C", Price = 20.0},
                new Item {Name = "D", Price = 15.0}
            };
        }

    }
}
