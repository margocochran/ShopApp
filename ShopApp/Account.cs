using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    /// <summary>
    /// Shopping User Account that holds information needed to make purchases.
    /// </summary>

    class Account
     {
        #region Properties
        /// <summary>
        /// Account information for user. Are there too many properties here? 
        /// </summary>

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string EmailAddress { get; set; }

        public string BillingAddress { get; set; }

        public int CreditCardNumber { get; set; }

        public string ShippingAddress { get; set; }

        #endregion

        #region Methods
    
          #endregion

       
    }
}
