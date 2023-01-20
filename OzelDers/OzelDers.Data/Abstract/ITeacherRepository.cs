using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Abstract
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        Task<List<Teacher>> GetHomePageTeachersAsync();
        Task<List<Teacher>> GetTeachersByBranchAsync(string branch);
        Task<List<Teacher>> GetAllTeachersAsync();
        Task CreateTeacherAsync(Teacher teacher, int[] selectedBranchIds);
        Task<Teacher> GetTeacherWithBranches(int id);
        Task UpdateTeacherAsync(Teacher teacher, int[] selectedBranchIds);
       
    }
}
