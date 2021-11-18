using Grocery.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grocery.UI.DataAccess
{
    public interface Iinventory
    {
        IEnumerable<GroceryItem> GetAll();

        
    }
}
