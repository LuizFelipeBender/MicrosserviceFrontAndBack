using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GeekShopping.ProductAPI.Data;
using GeekShopping.ProductAPI.Model.Entity;
using GeekShopping.ProductAPI.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MysqlContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(MysqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductVO>> FindAllProductsAsync()
        {
            List<ProductEntity> products = await _context.ProductEntities.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindByIdAsync(ulong id)
        {
            ProductEntity products = await _context.ProductEntities.Where(p => p.Id == id)
            .FirstOrDefaultAsync();
            return _mapper.Map<ProductVO>(products);
        }

        public async Task<ProductVO> CreateAsync(ProductVO vo)
        {
            ProductEntity product = _mapper.Map<ProductEntity>(vo);
            _context.ProductEntities.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);
        }

        public async Task<ProductVO> UpdateAsync(ProductVO vo)
        {
            ProductEntity product = _mapper.Map<ProductEntity>(vo);
            _context.ProductEntities.Update(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductVO>(product);

        }

        public async Task<bool> DeleteAsync(ulong id)
        {
            try
            {
            ProductEntity product = await _context.ProductEntities.Where(p => p.Id == id)
            .FirstOrDefaultAsync();
            if (product == null) return false;
            _context.ProductEntities.Remove(product);
            await _context.SaveChangesAsync();
            return true ;
            }
            catch (System.Exception)
            {
                return false;                
            }
        }

    }
}