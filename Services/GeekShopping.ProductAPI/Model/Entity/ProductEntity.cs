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
        [Required(ErrorMessage = "Completion is required for price")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Range(0.1, 1000000, ErrorMessage = "Price must be between 0.1 and 1000000")]
        public decimal UnitPrice { get; set; }

        [Column("Description")]
        [DisplayName("Description")]
        [Required(ErrorMessage = "Completion is required for decription")]
        [StringLength(200)]
        public string Description { get; set; }
 
        [Column("Category_Name")]
        [DisplayName("Category Name")]
        [Required(ErrorMessage = "Completion is required for category name")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("Image_Url")]
        [DisplayName("Image URL")]
        [Required(ErrorMessage = "Completion is required for Image URL")]
        [StringLength(250)]
        public string UrlImage { get; set; }


        }
}