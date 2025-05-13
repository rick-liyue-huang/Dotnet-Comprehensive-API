

using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Seeders;

internal class DataSeeder(RestaurantDbContext dbContext): IDataSeeder
{
    public async Task SeedAsync()
    {
        if (await dbContext.Database.CanConnectAsync())
        {
            if (!dbContext.Restaurants.Any())
            {
                var restaurants = GetRestaurants();
                dbContext.Restaurants.AddRange(restaurants);
                await dbContext.SaveChangesAsync();
            }
        }
    }


    private IEnumerable<Restaurant> GetRestaurants()
    {
        List<Restaurant> restaurants = [
            new()
            {
                Name = "KFC",
                Category = "Fast Food",
                Description = "Kentucky Fried Chicken",
                ContactEmail = "kfc@gmail.com",
                HasDelivery = true,
                Dishes = [
                    new()
                    {
                        Name = "Chicken Bucket",
                        Description = "A bucket of fried chicken",
                        Price = 19.99m
                    },
                    new()
                    {
                        Name = "French Fries",
                        Description = "Crispy French fries",
                        Price = 2.99m
                    },
                    new()
                    {
                        Name = "Coleslaw",
                        Description = "Creamy coleslaw salad",
                        Price = 3.99m
                    }
                ],
                Address = new ()
                {
                    City = "New York",
                    Street = "123 Main St",
                    PostalCode = "10001",
                }
            },
        ];
        return restaurants;
    }
}

