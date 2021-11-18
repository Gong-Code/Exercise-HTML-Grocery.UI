using Grocery.UI.DataAccess;
using Grocery.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace Grocery.UI.Pages.GroceryStore
{
    public class DetailModel : PageModel
    {
        private readonly IShoppingCart _shoppingCart;

        [BindProperty]
        public double Price { get; set; }
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public int Quantity { get; set; }

        [BindProperty]
        public GroceryItem GroceryItem { get; private set; }

        public DetailModel(IShoppingCart shoppingCart)
        {

            _shoppingCart = shoppingCart;
        }


        public void OnGet(int id)
        {
            GroceryItem = _shoppingCart.GetAll().ToList().FirstOrDefault(x => x.GroceryID == id); //Search through all inventory item and find specific id, and return true or false.
        }

        public IActionResult OnPostAdd()
        {
            GroceryItem = _shoppingCart.GetAll().ToList().FirstOrDefault(x => x.GroceryID == Id);

            if (ModelState.IsValid)
            {
                var cartItem = _shoppingCart.GetAll().ToList().FirstOrDefault(x => x.GroceryID == Id);
                _shoppingCart.AddToCart(cartItem);
                return Page();
            }

            return Page();
        }



    }
}
