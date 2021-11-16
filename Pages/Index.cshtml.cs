using Grocery.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace Grocery.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<GroceryItem> Foods { get; set; }

        public readonly Inventory inventory;
        public IndexModel()
        {
            inventory = new Inventory();
        }

        public void OnGet()
        {
            Foods = inventory.GetAll().ToList();

        }

        public IActionResult OnPostBuy()
        {
            return RedirectToPage("/Index");
        }

        public IActionResult OnPostDetail()
        {
            return Page();
        }



    }
}
