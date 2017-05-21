using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Cart
    {
        #region Properties
        public int NumberOfProducts { get; private set; }

        public decimal TotalCost { get; private set; }
        #endregion

        #region Methods
        public void AmountOwed(decimal amount)
        {
            TotalCost = ShoppApp.Product
        }

        #endregion
    }
}
