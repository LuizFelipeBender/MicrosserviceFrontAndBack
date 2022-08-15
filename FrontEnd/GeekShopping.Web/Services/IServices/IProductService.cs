using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task <IEnumerable<ProductModel>> FindAllProductsAsync();

        Task<ProductModel> FindByIdProductAsync(ulong Id);

        Task<ProductModel> CreateProductAsync(ProductModel model);
        Task<ProductModel> UpdateProductAsync(ProductModel model);

        Task<ProductModel> DeleteByIdProductAsync(ulong Id);

    }
}