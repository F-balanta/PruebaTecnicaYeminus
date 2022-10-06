using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YeminusSoftware.Application.DataObjectModel;
using YeminusSoftware.Application.ErrorHandler;
using YeminusSoftware.Application.Interfaces;
using YeminusSoftware.Domain;

namespace YeminusSoftware.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<ProductDto>> GetProducts()
        {
            var productList = await _productService.GetProductList();
            return _mapper.Map<List<ProductDto>>(productList);
        }

        [HttpGet("{id:int}")]
        public async Task<ProductDto> GetProductById(int id)
        {
            var product = await _productService.GetProductById(id);
            return _mapper.Map<ProductDto>(product);
        }

        [HttpPost]
        public async Task<ProductDto> CreateProduct([FromBody] ProductForCreateDto product)
        {
            var mapped = _mapper.Map<Product>(product);
            var productCreated = await _productService.Create(mapped);
            return _mapper.Map<ProductDto>(productCreated);
        }

        [HttpPut]
        public async Task UpdateProduct([FromBody] ProductForUpdateDto productViewModel)
        {
            var mapped = _mapper.Map<Product>(productViewModel);
            if (mapped == null)
                throw new RestException(HttpStatusCode.NotFound, new { message = "El producto que deseas actualizar no existe" });
            await _productService.Update(mapped);
        }

        [HttpDelete("{id:int}")]
        public async Task DeleteProduct(int id)
        {
            var productDelete = await _productService.GetProductById(id);
            if(productDelete == null)
                throw new RestException(HttpStatusCode.NotFound, new { message = "El producto que deseas eliminar no existe" });
            
            await _productService.Delete(id);
        }
    }
}
