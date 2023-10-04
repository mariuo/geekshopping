using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Camisa mario kart",
                Price = new decimal(69.00),
                Description = "Description",
                ImageUrl =  "Http://loremipson",
                CategoryName = "T-shirt",
            }); 
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Jogo Mario kart",
                Price = new decimal(270.00),
                Description = "Jogo",
                ImageUrl =  "Http://loremipson",
                CategoryName = "VideoGame",
            });
        }

    }
}
