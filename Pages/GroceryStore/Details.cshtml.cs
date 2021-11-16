using Grocery.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace Grocery.UI.Pages.GroceryStore
{
    public class DetailModel : PageModel
    {
        public Inventory Inventory { get; }
        [BindProperty]
        public double Price { get; set; }
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public int Quantity { get; set; }

        public GroceryItem GroceryItem { get; private set; }

        public DetailModel()
        {
            Inventory = new Inventory();

        }


        public void OnGet(int id)
        {
            GroceryItem = Inventory.GetAll().ToList().FirstOrDefault(x => x.GroceryID == id);

        }

        public IActionResult OnPostAdd()
        {
            if (ModelState.IsValid)
            {

                var groceryItem = Inventory.GetAll().ToList().FirstOrDefault(x => x.GroceryID == Id);
                Inventory.AddToCart(groceryItem);
                return Page();
            }

            return Page();
        }



    }
}
