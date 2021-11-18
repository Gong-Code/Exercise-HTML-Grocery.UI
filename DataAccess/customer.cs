using Grocery.UI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Grocery.UI.Data
{
    public class customer
    {
        public IEnumerable<Customer> GetAllCustomers()
        {
            var path = @"C:\Users\gongm\source\repos\Grocery.UI\Data\Customers_JSON.json";
            var jsonCustomer = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<IEnumerable<Customer>>(jsonCustomer);

        }

    }
}
