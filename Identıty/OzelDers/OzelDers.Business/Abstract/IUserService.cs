using OzelDers.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Business.Abstract
{
    public interface IUserService
    {
        Task<User> GetByIdAsync(int id);
        Task<List<User>> GetAllAsync();
        Task CreateAsync(User user);
        void Delete(User user);
        void Update(User user); 
    }
}
