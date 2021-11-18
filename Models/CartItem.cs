using Grocery.UI.Model;
using System;
using System.Collections.Generic;

namespace Grocery.UI.Models
{
    public class CartItem
    {
        public List<GroceryItem> GroceryItems { get; set; } = new List<GroceryItem>();
       
        public string CartId { get; set; }             
        public DateTime DateCreated { get; set; }
        
    }
}
