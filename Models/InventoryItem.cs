using System.ComponentModel.DataAnnotations;

namespace groupActivity.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int Quantity { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string? Description { get; set; }
    }
}   