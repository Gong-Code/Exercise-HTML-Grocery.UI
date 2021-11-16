using Grocery.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery.UI.Models
{
    public class ShoppingCartDTO
    {
        public List<GroceryItem> GroceryItems { get; set; } = new List<GroceryItem>();
    }
}
