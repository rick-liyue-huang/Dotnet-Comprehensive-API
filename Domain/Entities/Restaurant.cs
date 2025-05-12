
namespace Domain.Entities;

public class Restaurant
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!; // string.Empty;
    public string Description { get; set; } = default!; // string.Empty;
    public string Category { get; set; } = default!; // string.Empty;
    public bool HasDelivery { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactNumber { get; set; }
    public Address? Address { get; set; }
    public List<Dish> Dishes { get; set; } = new();
    
    
    
    
    
    
    
    
    
    
    
}
