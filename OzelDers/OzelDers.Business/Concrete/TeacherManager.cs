using OzelDers.Business.Abstract;
using OzelDers.Data.Abstract;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeacherManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(Teacher teacher)
        {

            await _unitOfWork.Teachers.CreateAsync(teacher);
            await _unitOfWork.SaveAsync();
        }

        public async Task CreateTeacherAsync(Teacher teacher, int[] selectedBranchIds)
        {
            await _unitOfWork.Teachers.CreateTeacherAsync(teacher, selectedBranchIds);

        }

        public void Delete(Teacher teacher)
        {
            _unitOfWork.Teachers.Delete(teacher);
            _unitOfWork.Save();
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            return await _unitOfWork.Teachers.GetAllAsync();

        }

        public async Task<List<Teacher>> GetAllTeachersAsync()
        {
            return await _unitOfWork.Teachers.GetAllTeachersAsync();
        }

        public async Task<Teacher> GetByIdAsync(int id)
        {
            return await _unitOfWork.Teachers.GetByIdAsync(id);

        }

        public async Task<List<Teacher>> GetHomePageTeachersAsync()
        {
            return await _unitOfWork.Teachers.GetHomePageTeachersAsync();
        }

        public async Task<List<Teacher>> GetTeachersByBranchAsync(string branch)
        {
            return await _unitOfWork.Teachers.GetTeachersByBranchAsync(branch);
        }

        public async Task<Teacher> GetTeacherWithBranches(int id)
        {
            return await _unitOfWork.Teachers.GetTeacherWithBranches(id);
        }

        public  User GetUser(string userName, string id)
        {
             return _unitOfWork.Teachers.GetUser(userName,id);
        }

        public void Update(Teacher teacher)
        {
            _unitOfWork.Teachers.Update(teacher);
            _unitOfWork.Save();
        }

        public async Task UpdateTeacherAsync(Teacher teacher, int[] selectedBranchIds)
        {
            await _unitOfWork.Teachers.UpdateTeacherAsync(teacher, selectedBranchIds);
        }
    }
}
