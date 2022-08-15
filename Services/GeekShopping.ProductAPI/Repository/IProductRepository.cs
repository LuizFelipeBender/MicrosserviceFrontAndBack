using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekShopping.ProductAPI.ValueObjects;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {
    Task<IEnumerable<ProductVO>> FindAllProductsAsync();    
    Task<ProductVO> FindByIdAsync(ulong id);
    Task<ProductVO> CreateAsync(ProductVO vo);
    Task<ProductVO> UpdateAsync(ProductVO vo);
    Task<bool> DeleteAsync(ulong id);
    }
}