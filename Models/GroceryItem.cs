using Newtonsoft.Json;

namespace Grocery.UI.Model
{
    public class GroceryItem
    {

        public string Name { get; set; }
        [JsonProperty("imgsrc")]
        public string ImageSrc { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int GroceryID { get; set; }





    }
}
