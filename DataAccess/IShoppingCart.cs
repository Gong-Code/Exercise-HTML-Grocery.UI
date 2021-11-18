using Grocery.UI.Model;
using Grocery.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery.UI.DataAccess
{
    public interface IShoppingCart
    {
        IEnumerable<GroceryItem> GetAll();
        CartItem GetCart();
        void AddToCart(GroceryItem item);
    }
}
