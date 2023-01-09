using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzelDers.Entity.Concrete;

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

            builder.Property(t=>t.Location)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Gender)
                .IsRequired();

            builder.Property(t => t.About)
                .IsRequired()
                .HasMaxLength(500);

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
                    Location ="İstanbul",
                    Gender = "Erkek",
                    About = "Matematik Öğretmeni",
                    Url = "mert-muslu",
                    ImageUrl = "1.png",
                    PricePerHour = 400,
                    BranchId=1

                },
                new Teacher
                {
                    Id = 2,
                    FirstName = "Harun",
                    LastName = "Öztürk",
                    Location = "İstanbul",
                    Gender = "Erkek",
                    About = "Fizik Öğretmeni",
                    Url = "harun-ozturk",
                    ImageUrl = "2.png",
                    PricePerHour = 200,
                    BranchId = 1



                },
                new Teacher
                {
                    Id = 3,
                    FirstName = "Selin",
                    LastName = "Biçici",
                    Location = "Ankara",
                    Gender = "Kadın",
                    About = "Kimya Öğretmeni",
                    Url = "selin-bicici",
                    ImageUrl = "3.png",
                    PricePerHour = 200,
                    BranchId = 1




                },
                new Teacher
                {
                    Id = 4,
                    FirstName = "Gizem",
                    LastName = "Deniz",
                    Location = "İzmir",
                    Gender = "Kadın",
                    About = "Biyoloji Öğretmeni",
                    Url = "gizem-deniz",
                    ImageUrl = "4.png",
                    PricePerHour = 250,
                    BranchId = 1



                },
                new Teacher
                {
                    Id = 5,
                    FirstName = "Deniz",
                    LastName = "Demir",
                    Location = "İstanbul",
                    Gender = "Erkek",
                    About = "Matematik Öğretmeni",
                    Url = "deniz-demir",
                    ImageUrl = "5.png",
                    PricePerHour = 175,
                    BranchId = 1




                },
                new Teacher
                {
                    Id = 6,
                    FirstName = "Yusuf",
                    LastName = "Demirci",
                    Location = "İstanbul",
                    Gender = "Erkek",
                    About = "Tarih Öğretmeni",
                    Url = "yusuf-demirci",
                    ImageUrl = "6.png",
                    PricePerHour = 300,
                    BranchId = 1



                },
                new Teacher
                {
                    Id = 7,
                    FirstName = "Ahmet",
                    LastName = "Çetin",
                    Location = "Ankara",
                    Gender = "Erkek",
                    About = "Almanca Öğretmeni",
                    Url = "ahmet-cetin",
                    ImageUrl = "7.png",
                    PricePerHour = 300,
                    BranchId = 1




                },
                new Teacher
                {
                    Id = 8,
                    FirstName = "Okan",
                    LastName = "Alan",
                    Location = "İzmir",
                    Gender = "Erkek",
                    About = "Almanca Öğretmeni",
                    Url = "okan-alan",
                    ImageUrl = "8.png",
                    PricePerHour = 200,
                    BranchId = 1




                },
                new Teacher
                {
                    Id = 9,
                    FirstName = "Hakan",
                    LastName = "Kara",
                    Location = "İzmir",
                    Gender = "Erkek",
                    About = "Coğrafya Öğretmeni",
                    Url = "hakan-kara",
                    ImageUrl = "9.png",
                    PricePerHour = 250,
                    BranchId = 1




                },
                new Teacher
                {
                    Id = 10,
                    FirstName = "Hande",
                    LastName = "Karakaya",
                    Location = "İstanbul",
                    Gender = "Kadın",
                    About = "Edebiyat Öğretmeni",
                    Url = "hande-karakaya",
                    ImageUrl = "10.png",
                    PricePerHour = 350,
                    BranchId = 1




                }


            );
        }
    }
}
