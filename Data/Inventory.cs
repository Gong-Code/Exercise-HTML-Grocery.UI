using Grocery.UI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Grocery.UI.Model
{
    public class Inventory
    {
        public IEnumerable<GroceryItem> GetAll()
        {
            var path = @"C:\Users\gongm\source\repos\Grocery.UI\Data\Inventory_JSON.json";
            var jsonGrocery = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<IEnumerable<GroceryItem>>(jsonGrocery);
        }

        public void AddToCart(GroceryItem groceryItem)
        {
            ShoppingCartDTO cart = new ShoppingCartDTO();
            cart.GroceryItems.Add(groceryItem);
            JsonConvert.SerializeObject(cart);
        }

    }
}
