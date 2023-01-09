using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
                    UserName="admin",
                    NormalizedUserName="ADMIN",
                    BranchId=1,

                    FirstName = "Mert",
                    LastName = "Muslu",
                    Age = "24",
                    Gender="Erkek",
                    Location = "Yalova",
                    Url = "mert-muslu",
                    Email="admin@gmail.com",
                    NormalizedEmail="ADMIN@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="9999999999"


                },
                  new User
                {
                    UserName="harun",
                    NormalizedUserName="HARUN",
                    FirstName = "Harun",
                    LastName = "Öztürk",
                    Age = "25",
                    Gender="Erkek",
                    About = "Fizik Öğretmeni",
                    Experience = "4",
                    Location = "İstabul",
                    Url = "harun-ozturk",
                    ImageUrl = "2.png",
                    PricePerHour = 200,
                
                       Email="harun@gmail.com",
                    NormalizedEmail="HARUN@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="8888888888",
                    BranchId=1,
                    

                },
                    new User
                {
                              UserName="selin",
                    NormalizedUserName="SELİN",
                       FirstName = "Selin",
                    LastName = "Biçici",
                    Age = "26",
                    Gender="Kadın",
                    About = "Kimya Öğretmeni",
                    Experience = "4",
                    Location = "İstanbul",
                    Url = "selin-bicici",
                    ImageUrl = "3.png",
                    PricePerHour = 200,
                
                      Email="selin@gmail.com",
                    NormalizedEmail="SELIN@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="7777777777",
                    BranchId=2


                },
                  new User
                {
                        UserName="gizem",
                    NormalizedUserName="GIZEM",
                       FirstName = "Gizem",
                    LastName = "Deniz",
                    Age = "27",
                    Gender="Kadın",
                    About = "Biyoloji Öğretmeni",
                    Experience = "3",
                    Location = "Ankara",
                    Url = "gizem-deniz",
                    ImageUrl = "4.png",
                    PricePerHour = 250,
                   
                      Email="gizem@gmail.com",
                    NormalizedEmail="GIZEM@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="6666666666",
                    BranchId=3

                },
                  new User
                  {
                            UserName="deniz",
                    NormalizedUserName="DENIZ",
                      FirstName = "Deniz",
                    LastName = "Demir",
                    Age = "27",
                    Gender = "Erkek",
                    About = "Matematik Öğretmeni",
                    Experience = "3",
                    Location = "Ankara",

                    Url = "deniz-demir",
                    ImageUrl = "5.png",
                    PricePerHour = 175,
                    
                        Email="deniz@gmail.com",
                    NormalizedEmail="DENIZ@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="5555555555",
                    BranchId=4


                  },

                  new User
                  {
                               UserName="ali",
                    NormalizedUserName="ALI",
                       FirstName = "Ali",
                    LastName = "Kazancı",
                    Location = "İstanbul",
                    Gender = "Erkek",
                    Url = "ali-kazanci",
                    ImageUrl = "6.png",
                              Email="ali@gmail.com",
                    NormalizedEmail="ALI@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="4444444444",
                    BranchId=1

                  },
                  new User
                  {

                               UserName="kübra",
                    NormalizedUserName="KUBRA",
                       FirstName = "Kübra",
                     LastName = "Doğan",
                     Location = "İstanbul",
                     Gender = "Kadın",
                     Url = "kübra-dogan",
                     ImageUrl = "7.png",
                                     Email="kübra@gmail.com",
                    NormalizedEmail="KUBRA@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="3333333333",
                    BranchId=1

                  },

                  new User
                  {
                                         UserName="ismet",
                    NormalizedUserName="ISMET",
                       FirstName = "İsmet",
                     LastName = "Demirci",
                     Location = "İzmir",
                     Gender = "Erkek",
                     Url = "ismet-demirci",
                     ImageUrl = "8.png",
                                       Email="ismet@gmail.com",
                    NormalizedEmail="ISMET@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="2222222222",
                    BranchId=1

                  },

                  new User
                  {
                        UserName="melike",
                    NormalizedUserName="MELIKE",
                      FirstName = "Melike",
                     LastName = "Kızar",
                     Location = "Ankara",
                     Gender = "Kadın",
                     Url = "melike-demirci",
                     ImageUrl = "9.png",
                             Email="melike@gmail.com",
                    NormalizedEmail="MELIKE@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="1111111111",
                    BranchId=1

                  },

                  new User
                  {
                      UserName="osman",
                    NormalizedUserName="OSMAN",
                       FirstName = "Osman",
                     LastName = "Kurtar",
                     Location = "Ankara",
                     Gender = "Erkek",
                     Url = "osman-kurtar",
                     ImageUrl = "10.png",
                               Email="osman@gmail.com",
                    NormalizedEmail="OSMAN@GMAIL.COM",
                    EmailConfirmed=true,
                    PhoneNumber="9876543210",
                    BranchId=1

                  }


            };
            modelBuilder.Entity<User>().HasData(users);

            #region Parolaİşlemleri
            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Qwe123.");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Qwe123.");
            users[3].PasswordHash = passwordHasher.HashPassword(users[3], "Qwe123.");
            users[4].PasswordHash = passwordHasher.HashPassword(users[4], "Qwe123.");
            users[5].PasswordHash = passwordHasher.HashPassword(users[5], "Qwe123.");
            users[6].PasswordHash = passwordHasher.HashPassword(users[6], "Qwe123.");
            users[7].PasswordHash = passwordHasher.HashPassword(users[7], "Qwe123.");
            users[8].PasswordHash = passwordHasher.HashPassword(users[8], "Qwe123.");
            users[9].PasswordHash = passwordHasher.HashPassword(users[9], "Qwe123.");
            #endregion


            #region KullanıcıRolAtamaİşlemleri
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId=users[0].Id,
                    RoleId=roles.First(r=>r.Name=="Admin").Id
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
                    RoleId=roles.First(r=>r.Name=="Teacher").Id
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
                                  new IdentityUserRole<string>
                {
                    UserId=users[7].Id,
                    RoleId=roles.First(r=>r.Name=="Student").Id
                },
                                     new IdentityUserRole<string>
                {
                    UserId=users[8].Id,
                    RoleId=roles.First(r=>r.Name=="Student").Id
                },
                                        new IdentityUserRole<string>
                {
                    UserId=users[9].Id,
                    RoleId=roles.First(r=>r.Name=="Student").Id
                }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion

        }

    }
}
