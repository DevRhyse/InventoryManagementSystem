using System.ComponentModel.DataAnnotations;

public class InventoryItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter a name for the item.")]
    public string? Name { get; set; }
}


// namespace inventoryMS.Models;

// public class InventoryItem
// {
//     public string? Name { get; set; }
//     public int Id { get; set; }
// }

    // public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);