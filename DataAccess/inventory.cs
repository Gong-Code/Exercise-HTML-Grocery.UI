using Grocery.UI.DataAccess;
using Grocery.UI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Grocery.UI.Model
{
    public class inventory : Iinventory
    {        
        public IEnumerable<GroceryItem> GetAll() //Convert Jsonfile Inventory into text format.
        {
            var path = @"C:\Users\gongm\source\repos\Grocery.UI\DataSource\Inventory_JSON.json";
            var jsonGrocery = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<IEnumerable<GroceryItem>>(jsonGrocery);
        }

       

       

    }
}
