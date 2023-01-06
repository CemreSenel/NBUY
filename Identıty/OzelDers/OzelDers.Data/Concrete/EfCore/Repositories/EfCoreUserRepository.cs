using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Abstract;
using OzelDers.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Concrete.EfCore.Repositories
{
    public class EfCoreUserRepository : EfCoreGenericRepository<User>, IUserRepository
    {
        public EfCoreUserRepository(DbContext context) : base(context)
        {
        }
    }
}
