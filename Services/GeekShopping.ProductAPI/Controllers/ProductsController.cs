using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GeekShopping.ProductAPI.Repository;
using GeekShopping.ProductAPI.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository ?? throw new
            ArgumentNullException(nameof(repository));
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> GetFindAllAsync()
        {
            var product = await _repository.FindAllProductsAsync();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFindByIdAsync(ulong id)
        {
            var product = await _repository.FindByIdAsync(id);
            if (product == null) return NotFound();
            return Ok(product);

        }

        [HttpPost]
        public async Task<ActionResult<ProductVO>> CreateAsync([FromQuery] ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _repository.CreateAsync(vo);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromQuery] ProductVO vo)
        {
            if (vo == null) return BadRequest();
            var product = await _repository.UpdateAsync(vo);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(ulong id)
        {
            var status = await _repository.DeleteAsync(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }
}