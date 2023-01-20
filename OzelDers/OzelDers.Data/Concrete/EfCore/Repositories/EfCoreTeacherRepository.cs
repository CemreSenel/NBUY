using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete.EfCore.Context;
using OzelDers.Data.Config;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Concrete.EfCore.Repositories
{
    public class EfCoreTeacherRepository : EfCoreGenericRepository<Teacher>, ITeacherRepository
    {

        public EfCoreTeacherRepository(OzelDersContext context) : base(context)
        {
        }

        private OzelDersContext OzelDersContext
        {
            get { return _context as OzelDersContext; }
        }

        public async Task CreateTeacherAsync(Teacher teacher, int[] selectedBranchIds)
        {
            await OzelDersContext.Teachers.AddAsync(teacher);
            await OzelDersContext.SaveChangesAsync();
            teacher.TeacherBranches = selectedBranchIds
                .Select(brId => new TeacherBranch
                {
                    TeacherId = teacher.Id,
                    BranchId = brId
                }).ToList();
            await OzelDersContext.SaveChangesAsync();
        }

        public async Task<List<Teacher>> GetAllTeachersAsync()
        {
            return await OzelDersContext
                .Teachers
                .Include(t => t.User)
                .ToListAsync();
        }

        public async Task<List<Teacher>> GetHomePageTeachersAsync()
        {
            return await OzelDersContext
                .Teachers
                .Where(t => t.IsHome)
                .ToListAsync();

        }

        public async Task<List<Teacher>> GetTeachersByBranchAsync(string branch)
        {


            var teachers = OzelDersContext
                .Teachers
                  .AsQueryable();
            if (branch != null)
            {
                teachers = teachers
                    .Include(t => t.TeacherBranches)
                    .ThenInclude(tb => tb.Branch)
                    .Where(t => t.TeacherBranches.Any(tb => tb.Branch.Url == branch));

            }
            return await teachers.ToListAsync();

        }

        public async Task<Teacher> GetTeacherWithBranches(int id)
        {
            return await OzelDersContext
                .Teachers
                .Where(t => t.Id == id)
                .Include(t => t.TeacherBranches)
                .ThenInclude(tb => tb.Branch)
                .Include(t => t.User)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateTeacherAsync(Teacher teacher, int[] selectedBranchIds)
        {
            Teacher newTeacher = await OzelDersContext
                .Teachers
                .Include(t => t.TeacherBranches)
                .Include(t => t.User)
                .FirstOrDefaultAsync(t => t.Id == teacher.Id);
            newTeacher.TeacherBranches = selectedBranchIds
                .Select(brId => new TeacherBranch
                {
                    TeacherId = newTeacher.Id,
                    BranchId = brId
                }).ToList();
            OzelDersContext.Update(newTeacher);
            await OzelDersContext.SaveChangesAsync();
        }
    }
}
