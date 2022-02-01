using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebBS.Data.Models;
using WebBS.Data.Repository.Contract;

namespace WebBS.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly WebBSContext _context;

        public Repository(WebBSContext context)
        {
            _context = context;
        }

        virtual public async void AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        virtual public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        virtual public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        virtual public async void RemoveAsync(TEntity entity)
        {
            _context.Remove<TEntity>(entity);
            await _context.SaveChangesAsync();
        }
    }
}
