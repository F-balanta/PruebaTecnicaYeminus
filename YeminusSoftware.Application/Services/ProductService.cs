using System.Net;
using YeminusSoftware.Application.ErrorHandler;
using YeminusSoftware.Application.Interfaces;
using YeminusSoftware.Domain;
using YeminusSoftware.Domain.Repository;

namespace YeminusSoftware.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProductList() => await _productRepository.GetAllAsync();

        public async Task<Product> GetProductById(int id) => await _productRepository.GetByIdAsync(id);
        
        public async Task<Product> Create(Product product)
        {
            await ValidateProductIfExists(product);
            var newProduct = await _productRepository.AddAsync(product);
            return newProduct;
        }
       
        public async Task Update(Product product)
        {
            var productEdit = await _productRepository.GetByIdAsync(product.Code);
            if (productEdit == null)
                throw new RestException(HttpStatusCode.NotFound, new { message = "El producto que deseas actualizar no existe" });
            
            productEdit.Description = product.Description ?? product.Description;
            productEdit.Vat = product.Vat ?? product.Vat;
            productEdit.ForSale = product.ForSale ?? product.ForSale;
            productEdit.ImgUrl = product.ImgUrl ?? product.ImgUrl;
            productEdit.Price = product.Price ?? productEdit.Price;
        }
        public async Task Delete(int id)
        {
            var productDelete = await _productRepository.GetByIdAsync(id);
            if (productDelete == null)
                throw new RestException(HttpStatusCode.NotFound, new { message = "El producto que deseas eliminar ya existe" });
            
            await _productRepository.DeleteAsync(productDelete);
        }
        
        private async Task ValidateProductIfExists(Product product)
        {
            var existingProduct = await _productRepository.GetByIdAsync(product.Code);
            if (existingProduct != null)
                throw new RestException(HttpStatusCode.NotFound, new { message = "El producto ya existe" });
        } 
        
    }
}
