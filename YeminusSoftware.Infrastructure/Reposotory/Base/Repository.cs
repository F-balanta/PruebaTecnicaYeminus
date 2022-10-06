using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using YeminusSoftware.Domain.Base;
using YeminusSoftware.Domain.Repository.Base;
using YeminusSoftware.Infrastructure.Data;

namespace YeminusSoftware.Infrastructure.Reposotory
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly YeminusSoftwareContext _context;

        public Repository(YeminusSoftwareContext context)
        {
            _context = context;

        }
        public async Task<IReadOnlyList<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        
        public async Task<IReadOnlyList<T>> GetAsync(Expression<Func<T, bool>> predicate) => await _context.Set<T>().Where(predicate).ToListAsync();
        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);
        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
