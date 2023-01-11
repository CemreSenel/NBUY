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
                }
                


                );
        }
    }
}
