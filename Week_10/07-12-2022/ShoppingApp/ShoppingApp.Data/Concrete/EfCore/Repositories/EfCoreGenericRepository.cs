using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class,
        new()
    {
        protected readonly DbContext _context;

        public EfCoreGenericRepository(DbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity); //_context.product
        }

        public void Delete(TEntity entity)//Delete ın asenkron metodu yok void yaptık
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync(); 
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);

        }

        public void Update(TEntity entity)//Update ın asenkron metodu yok void yaptık
        {
            _context.Set<TEntity>().Update(entity); 
        }
    }
}
