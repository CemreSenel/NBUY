using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ITeacherRepository Teachers { get; }
        IStudentRepository Students { get; }
        IBranchRepository Branches { get; }
        IUserRepository Users { get; }  
        Task SaveAsync();
        void Save();
    }
}
