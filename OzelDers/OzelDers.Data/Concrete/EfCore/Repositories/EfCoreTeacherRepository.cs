using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete.EfCore.Context;
using OzelDers.Data.Config;
using OzelDers.Entity.Concrete;
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
    }
}
