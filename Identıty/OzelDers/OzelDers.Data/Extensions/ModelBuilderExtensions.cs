using Microsoft.EntityFrameworkCore;
using OzelDers.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Data;
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
                //  new Role
                //{
                //    Name="User",
                //    Description="User rolü",
                //    NormalizedName="USER"
                //},
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


                    FirstName = "Mert",
                    LastName = "Muslu",
                    Age = "24",
                    Gender="Erkek",
                    About = "Matematik Öğretmeni",
                    Experience = "5",
                    Location = "Yalova",
                    Url = "mert-muslu",
                    ImageUrl = "1.png",
                    PricePerHour = 400,
                    BranchId = 1,
                    UniversityId = 1
                },
                  new User
                {
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
                    BranchId = 3,
                    UniversityId = 2

                },  new User
                {

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
                    BranchId = 2,
                    UniversityId = 3
                },  new User
                {

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
                    BranchId = 4,
                    UniversityId = 4
                }

            };
            modelBuilder.Entity<User>().HasData(users);

        }
    }
}
