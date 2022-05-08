using Microsoft.EntityFrameworkCore;
using SampleProject.API.Model;

namespace SampleProject.API.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Grunge Skater Jeans", Price = 68, IsAvailable = true },
                new Product { Id = 2, Name = "Polo Shirt", Price = 35, IsAvailable = true },
                new Product { Id = 3, Name = "Skater Graphic T-Shirt", Price = 33, IsAvailable = true },
                new Product { Id = 4, Name = "Slicker Jacket", Price = 125, IsAvailable = true },
                new Product { Id = 5, Name = "Thermal Fleece Jacket", Price = 60, IsAvailable = true },
                new Product { Id = 6, Name = "Unisex Thermal Vest", Price = 95, IsAvailable = true },
                new Product { Id = 7, Name = "V-Neck Pullover", Price = 65, IsAvailable = true },
                new Product { Id = 8, Name = "V-Neck Sweater", Price = 65, IsAvailable = true },
                new Product { Id = 9, Name = "V-Neck T-Shirt", Price = 17, IsAvailable = true },
                new Product { Id = 10, Name = "Bamboo Thermal Ski Coat", Price = 99, IsAvailable = true },
                new Product { Id = 11, Name = "Cross-Back Training Tank", Price = 0, IsAvailable = false },
                new Product { Id = 12, Name = "Grunge Skater Jeans", Price = 68, IsAvailable = true },
                new Product { Id = 13, Name = "Slicker Jacket", Price = 125, IsAvailable = true },
                new Product { Id = 14, Name = "Stretchy Dance Pants", Price = 55, IsAvailable = true },
                new Product { Id = 15, Name = "Ultra-Soft Tank Top", Price = 22, IsAvailable = true },
                new Product { Id = 16, Name = "Unisex Thermal Vest", Price = 95, IsAvailable = true },
                new Product { Id = 17, Name = "V-Next T-Shirt", Price = 17, IsAvailable = true },
                new Product { Id = 18, Name = "Blueberry Mineral Water", Price = 2.8M, IsAvailable = true },
                new Product { Id = 19, Name = "Lemon-Lime Mineral Water", Price = 2.8M, IsAvailable = true },
                new Product { Id = 20, Name = "Orange Mineral Water", Price = 2.8M, IsAvailable = true },
                new Product { Id = 21, Name = "Peach Mineral Water", Price = 2.8M, IsAvailable = true },
                new Product { Id = 22, Name = "Raspberry Mineral Water", Price = 2.8M, IsAvailable = true },
                new Product { Id = 23, Name = "Strawberry Mineral Water", Price = 2.8M, IsAvailable = true },
                new Product { Id = 24, Name = "In the Kitchen with H+ Sport", Price = 24.99M, IsAvailable = true },
                new Product { Id = 25, Name = "Calcium 400 IU (150 tablets)", Price = 9.99M, IsAvailable = true },
                new Product { Id = 26, Name = "Flaxseed Oil 100 mg (90 capsules)", Price = 12.49M, IsAvailable = true },
                new Product { Id = 27, Name = "Iron 65 mg (150 caplets)", Price = 13.99M, IsAvailable = true },
                new Product { Id = 29, Name = "Multi-Vitamin (90 capsules)", Price = 9.99M, IsAvailable = true },
                new Product { Id = 30, Name = "Vitamin A 10,000 IU (125 caplets)", Price = 11.99M, IsAvailable = true },
                new Product { Id = 32, Name = "Vitamin C 1000 mg (100 tablets)", Price = 9.99M, IsAvailable = true },
                new Product { Id = 28, Name = "Magnesium 250 mg (100 tablets)", Price = 12.49M, IsAvailable = true },
                new Product { Id = 33, Name = "Vitamin D3 1000 IU (100 tablets)", Price = 12.49M, IsAvailable = true },
                new Product { Id = 31, Name = "Vitamin B-Complex (100 caplets)", Price = 12.99M, IsAvailable = true });

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Email = "Tajik.WorkEmail@example.com" },
                new User { Id = 2, Email = "hggjh@example.com" });
        }
    }
}
