using OzelDers.Entity.Concrete;
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
    }
}
