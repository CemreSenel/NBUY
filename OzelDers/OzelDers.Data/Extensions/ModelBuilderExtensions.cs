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
                     Email="student@gmail.com",
                     UserName="student",
                     NormalizedUserName="STUDENT",
                     NormalizedEmail="STUDENT@GMAIL.COM",

                },


                  new User
                  {
                     Id="teacher1",
                     Email="teacher1@gmail.com",
                     UserName="teacher1",
                     NormalizedUserName="TEACHER1",
                     NormalizedEmail="TEACHER1@GMAIL.COM",
                  },
                   new User
                  {
                     Id="teacher2",
                     Email="teacher2@gmail.com",
                     UserName="teacher2",
                     NormalizedUserName="TEACHER2",
                     NormalizedEmail="TEACHER2@GMAIL.COM",
                  },
                      new User
                  {
                     Id="teacher3",
                     Email="teacher3@gmail.com",
                     UserName="teacher3",
                     NormalizedUserName="TEACHER3",
                     NormalizedEmail="TEACHER3@GMAIL.COM",
                  },
                      new User
                      {
                          Id="admin",
                          Email="admin@gmail.com",
                          NormalizedEmail="ADMIN@GMAIL.COM",
                          UserName="admin",
                          NormalizedUserName="ADMIN",
                      },
                        new User

                {
                     Id="student2",
                     Email="veli@gmail.com",
                     UserName="veli",
                     NormalizedUserName="VELI",
                     NormalizedEmail="VELI@GMAIL.COM",

                },
                          new User

                {
                     Id="student3",
                     Email="mehmet@gmail.com",
                     UserName="mehmet",
                     NormalizedUserName="MEHMET",
                     NormalizedEmail="MEHMET@GMAIL.COM",

                },




            };
            modelBuilder.Entity<User>().HasData(users);

            var password = new PasswordHasher<User>();
            users[0].PasswordHash = password.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = password.HashPassword(users[1], "Qwe123.");
            users[2].PasswordHash = password.HashPassword(users[2], "Qwe123.");
            users[3].PasswordHash = password.HashPassword(users[3], "Qwe123.");
            users[4].PasswordHash = password.HashPassword(users[4], "Admin123.");
            users[5].PasswordHash = password.HashPassword(users[5], "Qwe123.");
            users[6].PasswordHash = password.HashPassword(users[6], "Qwe123.");

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
                 new IdentityUserRole<string>
                {
                    UserId=users[2].Id,
                    RoleId=roles.First(r=>r.Name=="Teacher").Id
                },
                 new IdentityUserRole<string>
                  {
                    UserId=users[3].Id,
                    RoleId=roles.First(r=>r.Name=="Teacher").Id
                },
                 new IdentityUserRole<string>
                   {
                    UserId=users[4].Id,
                    RoleId=roles.First(r=>r.Name=="Admin").Id
                },
                   new IdentityUserRole<string>
                   {
                    UserId=users[5].Id,
                    RoleId=roles.First(r=>r.Name=="Student").Id
                },
                     new IdentityUserRole<string>
                   {
                    UserId=users[6].Id,
                    RoleId=roles.First(r=>r.Name=="Student").Id
                },



            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

        }

    }
}




