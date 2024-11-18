using Microsoft.EntityFrameworkCore;
using Test_ENG.Models;

namespace Test_ENG.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                    new Categories
                    {
                        CategoryId = 1,
                        CategoryName = "Test1",
                        Description = "Test 1"
                    },
                    new Categories
                     {
                         CategoryId = 2,
                         CategoryName = "Test2",
                         Description = "Test 2"
                     }
                );


            modelBuilder.Entity<Products>().HasData(
                    new Products
                    {
                        ProductId = 1,
                        ProductName = "Product 1",
                        Description = "Product 1",
                        Price = 10,
                        IsActive = true,
                        CategoryId = 1

                    },
                    new Products
                    {
                        ProductId = 2,
                        ProductName = "Product 2",
                        Description = "Product 2",
                        Price = 10,
                        IsActive = true,
                        CategoryId = 1
                    },
                    new Products
                    {
                        ProductId = 3,
                        ProductName = "Product 3",
                        Description = "Product 3",
                        Price = 10,
                        IsActive = true,
                        CategoryId = 2
                    },
                    new Products
                    {
                        ProductId = 4,
                        ProductName = "Product 4",
                        Description = "Product 4",
                        Price = 10,
                        IsActive = true,
                        CategoryId = 2
                    }
                );
        }



    }
    }
