using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.ViewModel
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        [DisplayName ("Product Name")]
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price {  get; set; }
        [DisplayName("Stock level")]
        public int Count { get; set; }
        public int InventoryValue {  get; set; }
    }
}
