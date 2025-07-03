using System.ComponentModel.DataAnnotations;

namespace StorageApi.Models.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
         
        [Required(ErrorMessage = "Count is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Count must be a non-negative integer.")]
        public int Count { get; set; }
        public int InventoryValue => Price * Count;
    }
}
