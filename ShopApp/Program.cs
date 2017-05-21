using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            //User creates new account to make purchases

            account.UserName = "margo2007";
            account.FullName = "Margo Cochran";
            account.EmailAddress = "test@test.com"; 

        }
    }
}
