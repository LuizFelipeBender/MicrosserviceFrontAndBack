using GeekShopping.ProductAPI.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Data
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(){}
        public MysqlContext(DbContextOptions<MysqlContext> options): base(options) {}
        public DbSet<ProductEntity> ProductEntities {get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
            
        //     base.OnModelCreating(modelBuilder);
        // }

    }
}