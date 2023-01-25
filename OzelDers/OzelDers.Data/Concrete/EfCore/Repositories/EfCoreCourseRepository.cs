using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete.EfCore.Context;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCourseRepository : EfCoreGenericRepository<Course>, ICourseRepository
    {
        public EfCoreCourseRepository(DbContext context) : base(context)
        {
        }
        private OzelDersContext OzelDersContext
        {
            get { return _context as OzelDersContext; }
        }

        public Task<Teacher> GetTeachersByCourses(int id)
        {
            var course = OzelDersContext
                .Teachers
                .Where(t => t.Id == id)
                .Include(t => t.TeacherCourses)
                .ThenInclude(tc => tc.Course)
                .Include(t => t.User)
                .FirstOrDefaultAsync();
            return course;
        }
    }
}
