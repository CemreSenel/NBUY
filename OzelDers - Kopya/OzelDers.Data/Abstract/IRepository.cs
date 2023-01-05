using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);//Id'ye göre entity getirecek.
        Task<List<T>> GetAllAsync();//Tüm kayıtları getirecek.
        Task CreateAsync(T entity);//Yeni kayıt yaratacak.
        void Update(T entity);//Kayıt güncelleyecek.
        void Delete(T entity);//Kayıt silecek.
    }
}
