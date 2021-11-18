using Grocery.Core.Models;
using Grocery.Data.DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace Grocery.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IInventoryDataAccess inventoryDataAccess;

        public List<Product> Foods { get; set; }
       

        public IndexModel(IInventoryDataAccess inventoryDataAccess)
        {
            this.inventoryDataAccess = inventoryDataAccess;
        }

        public void OnGet()
        {
            Foods = inventoryDataAccess.GetAll();

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
