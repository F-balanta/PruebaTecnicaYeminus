using YeminusSoftware.Domain;
using YeminusSoftware.Domain.Repository;
using YeminusSoftware.Infrastructure.Data;

namespace YeminusSoftware.Infrastructure.Reposotory
{
    public class EncryptRepository : Repository<Encrypt>, IEncryptRepository
    {
        private readonly YeminusSoftwareContext _context;

        public EncryptRepository(YeminusSoftwareContext context) : base(context)
        {
            _context = context;

        }
    }
}
