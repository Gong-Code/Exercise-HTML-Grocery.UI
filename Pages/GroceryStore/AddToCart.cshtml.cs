using Grocery.UI.DataAccess;
using Grocery.UI.Model;
using Grocery.UI.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace Grocery.UI.Pages.GroceryStore
{
    public class AddToCart : PageModel
    {
        private readonly IShoppingCart _shoppingCart;

        public List<CartItem> CartItem { get; set; }
        public AddToCart(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public void OnGet(int Id)
        {
            var cartItem = _shoppingCart.GetAll().ToList();

            if (cartItem != null)
            {
                CartItem.AddRange(CartItem);
            }

            if (Id != 0)
            {
                
            }
        }
    }
}
