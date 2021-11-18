using Grocery.UI.DataAccess;
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
       
        private readonly Iinventory _inventory;

        public IndexModel(Iinventory inventory)
        {
            _inventory = inventory;
        }

        public void OnGet()
        {
            Foods = _inventory.GetAll().ToList();

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
