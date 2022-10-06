using YeminusSoftware.Domain;

namespace YeminusSoftware.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductList();
        Task<Product> GetProductById(int id);
        Task<Product> Create(Product product);
        Task Update(Product product);
        Task Delete(int id);
    }
}