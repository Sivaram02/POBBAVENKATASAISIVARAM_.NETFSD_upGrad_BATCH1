using Microsoft.EntityFrameworkCore;
using healthcareapi.Data;
using healthcareapi.Repositories.Interfaces;

namespace healthcareapi.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HealthcareDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(HealthcareDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("Entity not found");

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}