using Grocery.UI.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Grocery.UI.Pages
{
    public class IndexModel : PageModel
    {
        public List<GroceryItem> Foods;

        public void OnGet()
        {

        }
    }
}
