namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        public ulong Id { get; set; }
        public string Product_Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string UrlImage { get; set; }
    
    }
}