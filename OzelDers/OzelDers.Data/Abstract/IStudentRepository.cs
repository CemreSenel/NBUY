﻿using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Abstract
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<List<Student>> GetAllStudentsAsync();
        Task CreateStudentAsync(Student student);
        Task<Student> GetStudentWithUser(int id);
    }
}
