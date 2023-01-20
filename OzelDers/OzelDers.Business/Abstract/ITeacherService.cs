using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
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
        Task<List<Teacher>> GetAllTeachersAsync();
        Task CreateTeacherAsync(Teacher teacher, int[] selectedBranchIds);
        Task<Teacher> GetTeacherWithBranches(int id);
        Task UpdateTeacherAsync(Teacher teacher , int[] selectedBranchIds);
       
    }
}
