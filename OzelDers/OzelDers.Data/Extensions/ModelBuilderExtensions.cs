using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Config;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            List<Role> roles = new List<Role>
            {
                new Role
                {
                    Name="Admin",
                    NormalizedName="ADMIN",
                    Description="Admin rolü"

                },

                  new Role
                {
                    Name="Student",
                    Description="Student rolü",
                    NormalizedName="STUDENT"
                },
                  new Role
                {
                    Name="Teacher",
                    Description="Teacher rolü",
                    NormalizedName="TEACHER"
                }
            };
            modelBuilder.Entity<Role>().HasData(roles);
            List<User> users = new List<User>
            
            {
                new User

                {
                     Id="student",
                     Email="student@gmail.com"

                },


                  new User
                  {
                           Id="teacher",
                     Email="teacher@gmail.com"
                  }
         



            };
            modelBuilder.Entity<User>().HasData(users);



            #region KullanıcıRolAtamaİşlemleri
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId=users[0].Id,
                    RoleId=roles.First(r=>r.Name=="Student").Id
                },
                new IdentityUserRole<string>
                {
                    UserId=users[1].Id,
                    RoleId=roles.First(r=>r.Name=="Teacher").Id
                },
          


            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

        }

    }
}
