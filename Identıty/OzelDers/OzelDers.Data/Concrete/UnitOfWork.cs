using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete.EfCore.Context;
using OzelDers.Data.Concrete.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OzelDersContext _context;

        public UnitOfWork(OzelDersContext context)
        {
            _context = context;
        }
        private EfCoreTeacherRepository _teacherRepository;
        private EfCoreStudentRepository _studentRepository;
        private EfCoreBranchRepository _branchRepository;
        private EfCoreUserRepository _userRepository;

        public ITeacherRepository Teachers => _teacherRepository = _teacherRepository ?? new EfCoreTeacherRepository(_context);

        public IStudentRepository Students => _studentRepository = _studentRepository ?? new EfCoreStudentRepository(_context);

        public IBranchRepository Branches => _branchRepository = _branchRepository ?? new EfCoreBranchRepository(_context);

        public IUserRepository Users => _userRepository = _userRepository ?? new EfCoreUserRepository(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
