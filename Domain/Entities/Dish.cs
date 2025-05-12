using System;

namespace Domain.Entities;

public class Dish
{
    public int Id { get; set; }
    
    public string? Name { get; set; } = default!; // string.Empty;
    public string? Description { get; set; } = default!; // string.Empty;
    public decimal Price { get; set; }
}
