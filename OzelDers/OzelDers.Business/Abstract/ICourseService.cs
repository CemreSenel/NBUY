using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Business.Abstract
{
    public interface ICourseService
    {
        Task<Course> GetByIdAsync(int id);
        Task<List<Course>> GetAllAsync();
        Task CreateAsync(Course course);
        void Delete(Course course);
        void Update(Course course);
        Task<Teacher> GetTeachersByCourses(int id);
    }
}
