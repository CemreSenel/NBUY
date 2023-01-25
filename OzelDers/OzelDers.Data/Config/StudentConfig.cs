using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Config
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.Property(s => s.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.Location)
                .HasMaxLength(50);


            builder.Property(t => t.Url)
                .HasMaxLength(250);

            builder.Property(t => t.ImageUrl)
                .HasMaxLength(250);

            builder.ToTable("Students");

            builder.HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Kazancı",
                    Location = "İstanbul",
                    Gender = "Erkek",
                    Url = "ali-kazanci",
                    ImageUrl = "1.png",
                    UserId="student"
                },
                   new Student
                   {
                       Id = 2,
                       FirstName = "Veli",
                       LastName = "Kazancı",
                       Location = "İstanbul",
                       Gender = "Erkek",
                       Url = "veli-kazanci",
                       ImageUrl = "2.png",
                       UserId = "student2"
                   },
                      new Student
                      {
                          Id = 3,
                          FirstName = "Mehmet",
                          LastName = "Kazancı",
                          Location = "İstanbul",
                          Gender = "Erkek",
                          Url = "mehmet-kazanci",
                          ImageUrl = "3.png",
                          UserId = "student3"
                      }



                );
        }
    }
}
