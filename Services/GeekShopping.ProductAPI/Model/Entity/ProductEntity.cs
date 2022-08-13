using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.ProductAPI.Model.Entity
{
    public class ProductEntity :BaseEntity
    {
        [Column("Product")]
        [DisplayName("Product")]
        [Required(ErrorMessage = "Completion is required for {0} name")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "The product name must be at least {1} characters and at most {0}")]
        public string Product_Name { get; set; }

        [Column("Price")]
        [DisplayName("Price")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(0, 1000000)]
        public decimal UnitPrice { get; set; }

        [Column("Description")]
        [DisplayName("Description")]
        public string Description { get; set; }
 
        [Column("Category_Name")]
        [DisplayName("Category Name")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("Url_image")]
        [DisplayName("Image URL")]
        [StringLength(150)]
        public string UrlImage { get; set; }


        }
}