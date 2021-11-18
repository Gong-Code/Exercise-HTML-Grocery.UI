using Grocery.UI.Model;
using Grocery.UI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Grocery.UI.DataAccess
{
    public class ShoppingCart : IShoppingCart
    {
        public IEnumerable<GroceryItem> GetAll()
        {
            var path = @"C:\Users\gongm\source\repos\Grocery.UI\DataSource\Inventory_JSON.json";
            var jsonGrocery = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<IEnumerable<GroceryItem>>(jsonGrocery);
        }
        public CartItem GetCart() //Convert Jsonfile ShoppingCart into text format.
        {
            var path = @"C:\Users\gongm\source\repos\Grocery.UI\DataSource\ShoppingCart.json";
            var jsonResponse = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<CartItem>(jsonResponse);
        }

        public void AddToCart(GroceryItem item) //Add an item into Jsonfile-ShoppingCart.
        {
            var path = @"C:\Users\gongm\source\repos\Grocery.UI\DataSource\ShoppingCart.json";
            CartItem cart = GetCart();
            if (cart == null)
            {
                cart = new CartItem();
            }
            cart.GroceryItems.Add(item);
            var jsonResponse = JsonConvert.SerializeObject(cart);
            File.WriteAllText(path, jsonResponse);

        }

       
    }
}
