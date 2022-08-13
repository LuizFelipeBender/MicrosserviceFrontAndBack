using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekShopping.ProductAPI.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Data
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(){}
        public MysqlContext(DbContextOptions<MysqlContext> options): base(options) {}
        DbSet<ProductEntity> ProductEntities {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }

    }
}