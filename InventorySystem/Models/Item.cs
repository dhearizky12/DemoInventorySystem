using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventorySystem.Models;

public class Item
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdItem { get; set; }
    [Required]
    public string KodeItem { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Quantity { get; set; }
    public string? Description { get; set; }
    public bool Availability { get; set; } = true;
}
