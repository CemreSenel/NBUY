﻿using BlogApp.Entities.Concrete;
using BlogApp.Shared.Data.Abstract;
using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {

    }
}
