using GeekShopping.ProductAPI.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Data
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(){}
        public MysqlContext(DbContextOptions<MysqlContext> options): base(options) {}
        public DbSet<ProductEntity> ProductEntities {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().ToTable("Product_Entities");
            modelBuilder.Entity<ProductEntity>().HasData(new ProductEntity
            {
                Id = 17,
                Product_Name = "Chocolate Cake",
                CategoryName = "Cakes",
                Description = "Description",    
                UnitPrice = new decimal(21.17),
                UrlImage = "https://img.elo7.com.br/product/zoom/2A2D7C9/bolo-de-kit-kat-15-anos.jpg",
            });

        }

    }
}