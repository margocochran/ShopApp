using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Product
    {
        public class ItemName
        {
            public string Name { get; private set; }

            public string Description { get; private set; }
        }

        public class ItemCost
        {
            public decimal Price  { get; private set; }
        }
}
