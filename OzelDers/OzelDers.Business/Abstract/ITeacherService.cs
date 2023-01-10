using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Business.Abstract
{
    public interface ITeacherService
    {
        Task<Teacher> GetByIdAsync(int id);
        Task<List<Teacher>> GetAllAsync();
        Task CreateAsync(Teacher teacher);
        void Delete(Teacher teacher);
        void Update(Teacher teacher);

        Task<List<Teacher>> GetHomePageTeachersAsync();
        Task<List<Teacher>> GetTeachersByBranchAsync(string branch);
    }
}
