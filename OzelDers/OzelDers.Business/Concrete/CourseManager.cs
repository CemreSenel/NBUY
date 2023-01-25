using OzelDers.Business.Abstract;
using OzelDers.Data.Abstract;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourseManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task CreateAsync(Course course)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Teacher> GetTeachersByCourses(int id)
        {
            return await _unitOfWork.Courses.GetTeachersByCourses(id);
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
