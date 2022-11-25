using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate,params Expression<Func<T, object>>[] includeProperties); //Not-1,Not-2

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties); //Not-3

        Task AddAsync(T entity); 
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T,bool>>predicate);
        Task<int> CountAsync(Expression<Func<T,bool>>predicate);


    }
}

/*
 Not-1:Örnegın Id si 12 olan Article'ı getırmek ıstıyoruz
var article = repository.GetAsync(x=>x.Id==12);

User user =repositoryUser.GetAsync(x=>x.Name == "enginniyazi")


Not-2:Örnegın Id si 12 olan Article ı User ve Commenlerıyle bırlıkte getırmek ıstıyoruz
var article = repositoryArticle.GetAsync(x=>x.Id==12,y=>y.User,y=>y.Comments,z=>z.Role)

Not-3:Ornegın tum article ları listelemek ıstıyoruz
var articles =repositoryArticle.GetAllAsync();

Örnegin DotNet kategorisindekı tum Article ları listelemek istiyoruz
var articles = repositoryArticle.GetAllAsync(a=>a.Category.Name=="DotNet",c=>c.Category)

Örneğin Id sı 12 olan Article ın yorumlaarını getirmek ıstıyoruz
var comments = repositoryComment.GetAllAsync(c=>c.ArticleId==12)

 */
