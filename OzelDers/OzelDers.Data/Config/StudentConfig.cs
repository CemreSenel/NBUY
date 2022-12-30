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
    public class StudentConfig : IEntityTypeConfiguration<Student>
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


            builder.Property(s => s.Age)
                .IsRequired();

            builder.Property(t => t.Gender)
               .IsRequired();

            builder.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(t => t.ImageUrl)
                .IsRequired()
                .HasMaxLength(250);

            builder.ToTable("Students");

            builder.HasData(
                new Student
                {
                    Id = 1,
                    FirstName="Ali",
                    LastName="Kazancı",
                    Age="15",
                    Gender="Erkek",
                    Url="ali-kazanci",
                    ImageUrl="1.png"
                },
                 new Student
                 {
                     Id = 2,
                     FirstName = "Kübra",
                     LastName = "Doğan",
                     Age = "17",
                     Gender = "Kadın",
                     Url = "kübra-dogan",
                     ImageUrl = "2.png"
                 }, new Student
                 {
                     Id = 3,
                     FirstName = "İsmet",
                     LastName = "Demirci",
                     Age = "16",
                     Gender = "Erkek",
                     Url = "ismet-demirci",
                     ImageUrl = "3.png"
                 }, new Student
                 {
                     Id = 4,
                     FirstName = "Melike",
                     LastName = "Kızar",
                     Age = "18",
                     Gender = "Kadın",
                     Url = "melike-demirci",
                     ImageUrl = "4.png"
                 }, new Student
                 {
                     Id = 5,
                     FirstName = "Osman",
                     LastName = "Kurtar",
                     Age = "19",
                     Gender = "Erkek",
                     Url = "osman-kurtar",
                     ImageUrl = "5.png"
                 }



                );

        }
    }
}
