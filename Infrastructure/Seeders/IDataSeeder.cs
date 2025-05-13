using System;

namespace Infrastructure.Seeders;

public interface IDataSeeder
{
    Task SeedAsync();
}
