using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.ViewModel
{
    public class CreateEditProductViewModel
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required]
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        
        public DateTime? Orderdate { get; set; }

        public string? Category { get; set; }
        public string? Shelf { get; set; }

        [Range(0, int.MaxValue)]
        public int Count { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
    }
}
