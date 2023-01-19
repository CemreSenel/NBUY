﻿using Microsoft.EntityFrameworkCore;
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
    public class EfCoreStudentRepository : EfCoreGenericRepository<Student>, IStudentRepository
    {
        public EfCoreStudentRepository(OzelDersContext context) : base(context)
        {
        }
        private OzelDersContext OzelDersContext
        {
            get { return _context as OzelDersContext; }
        }

        public async Task CreateStudentAsync(Student student)
        {
            await OzelDersContext.Students.AddAsync(student);
            await OzelDersContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await OzelDersContext
                .Students
                .Include(s => s.User)
                .ToListAsync();
        }
    }
}
