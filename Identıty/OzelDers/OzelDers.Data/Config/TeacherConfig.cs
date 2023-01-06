using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Config
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Age)
                .IsRequired();

            builder.Property(t => t.Gender)
                .IsRequired();

            builder.Property(t => t.About)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.Experience)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(t => t.ImageUrl)
                .IsRequired()
                .HasMaxLength(250);

            builder.ToTable("Teachers");

            builder.HasData(
                new Teacher
                {
                    Id = 1,
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
                new Teacher
                {
                    Id = 2,
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
                },
                new Teacher
                {
                    Id = 3,
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
                },
                new Teacher
                {
                    Id = 4,
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
                },
                new Teacher
                {
                    Id = 5,
                    FirstName = "Deniz",
                    LastName = "Demir",
                    Age = "28",
                    Gender="Erkek",
                    About = "Matematik Öğretmeni",
                    Experience = "2",
                    Location = "İstanbul",
                    Url = "deniz-demir",
                    ImageUrl = "5.png",
                    PricePerHour = 175,
                    BranchId = 1,
                    UniversityId = 5
                },
                new Teacher
                {
                    Id = 6,
                    FirstName = "Yusuf",
                    LastName = "Demirci",
                    Age = "29",
                    Gender="Erkek",
                    About = "Tarih Öğretmeni",
                    Experience = "7",
                    Location = "İstanbul",
                    Url = "yusuf-demirci",
                    ImageUrl = "6.png",
                    PricePerHour = 300,
                    BranchId = 5,
                    UniversityId = 6
                },
                new Teacher
                {
                    Id = 7,
                    FirstName = "Ahmet",
                    LastName = "Çetin",
                    Age = "28",
                    Gender="Erkek",
                    About = "Almanca Öğretmeni",
                    Experience = "3",
                    Location = "İstanbul",
                    Url = "ahmet-cetin",
                    ImageUrl = "7.png",
                    PricePerHour = 300,
                    BranchId = 7,
                    UniversityId = 7
                },
                new Teacher
                {
                    Id = 8,
                    FirstName = "Okan",
                    LastName = "Alan",
                    Age = "27",
                    Gender="Erkek",
                    About = "Almanca Öğretmeni",
                    Experience = "2",
                    Location = "Kocaeli",
                    Url = "okan-alan",
                    ImageUrl = "8.png",
                    PricePerHour = 200,
                    BranchId = 7,
                    UniversityId = 8
                },
                new Teacher
                {
                    Id = 9,
                    FirstName = "Hakan",
                    LastName = "Kara",
                    Age = "26",
                    Gender="Erkek",
                    About = "Coğrafya Öğretmeni",
                    Experience = "5",
                    Location = "Kocaeli",
                    Url = "hakan-kara",
                    ImageUrl = "9.png",
                    PricePerHour = 250,
                    BranchId = 9,
                    UniversityId = 9
                },
                new Teacher
                {
                    Id = 10,
                    FirstName = "Hande",
                    LastName = "Karakaya",
                    Age = "25",
                    Gender="Kadın",
                    About = "Edebiyat Öğretmeni",
                    Experience = "4",
                    Location = "Kocaeli",
                    Url = "hande-karakaya",
                    ImageUrl = "10.png",
                    PricePerHour = 350,
                    BranchId = 6,
                    UniversityId = 10
                }


            );


        }
    }
}
