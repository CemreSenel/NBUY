using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);//Id ye gore entity getirecek.
        Task<List<T>> GetAllAsync(); //İlgili tüm kayıtları getirecek.
        Task CreateAsync(T entity); //Yeni kayıt yaratıcak
        void Update(T entity); //kayıt guncelleyecek
        void Delete(T entity);   //kayıt silecek.
    }
}
