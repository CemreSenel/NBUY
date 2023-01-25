﻿using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Abstract
{
    public interface ICourseRepository : IRepository<Course>
    {
        Task<Teacher> GetTeachersByCourses(int id);
    }
}