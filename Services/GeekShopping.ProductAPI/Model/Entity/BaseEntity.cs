using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GeekShopping.ProductAPI.Model.Entity
{
    public class BaseEntity
    {
        [Key] 
        [Column("id")]
        public ulong Id { get; set; }
    }
}