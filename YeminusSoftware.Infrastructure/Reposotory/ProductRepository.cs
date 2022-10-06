using YeminusSoftware.Domain;
using YeminusSoftware.Domain.Repository;
using YeminusSoftware.Infrastructure.Data;

namespace YeminusSoftware.Infrastructure.Reposotory
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly YeminusSoftwareContext _context;

        public ProductRepository(YeminusSoftwareContext context) : base(context)
        {
            _context = context;
        }
    }
}
