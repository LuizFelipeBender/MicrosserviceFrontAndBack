using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.ProductAPI.ValueObjects
{
    public class ProductVO
    {
        public ulong Id { get; set; }
        public string Product_Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string UrlImage { get; set; }
    }
}