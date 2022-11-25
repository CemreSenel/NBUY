using BlogApp.Shared.Data.Abstract;
using BlogApp.Shared.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class,
        IEntity,
        new()
 
    {
        private readonly DbContext _context;

        public EfEntityRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);   
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().CountAsync(predicate);
        }

        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        }
        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Update(entity); });  
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            //Burada context e erısıp hangi entity de calısacaksak o entıty yı IQuerble tıpınde alıyoruz 
            IQueryable<TEntity> query = _context.Set<TEntity>(); 
            if (predicate!=null) //Predicate null degılse bu bır kosul belırtmıs demektır.Dolayısıyla bu durumda o kosulu(predıcate) if ıcınde Where ile query uzerıne eklıyorum.Eger predicate null ıse query üzerıne where ile ilgili bır sey eklemememıze gerek yok
            {
                query = query.Where(predicate);   
            }
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties) 
                {
                    query = query.Include(includeProperty);
                }
            }
            //Artık ToListAsync yapılabılecek query elımızde . Bız de gerıye dondurecegımız query yi TOListAsync ile listeye cevırıyoruz cunku bu metot gerıye bır liste dondurmesı gerekıyor.
            return await  query.ToListAsync();    
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().Where(predicate);
            //query=query.Where(predicate);
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return await query.FirstOrDefaultAsync();
            //return await query.SingleOrDefaultAsync();  

        }

       
    }
}
