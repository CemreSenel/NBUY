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

            builder.Property(t => t.Location)
                .HasMaxLength(50);

            builder.Property(t => t.About)
                .HasMaxLength(500);

            builder.Property(t => t.Url)
                .HasMaxLength(250);

            builder.Property(t => t.ImageUrl)
                .HasMaxLength(250);


            builder.ToTable("Teachers");

            builder.HasData(
                new Teacher
                {
                    Id = 1,
                    FirstName = "Mert",
                    LastName = "Muslu",
                    Location = "İstanbul",
                    Gender = "Erkek",
                    About = "Matematik Öğretmeni",
                    Url = "mert-muslu",
                    ImageUrl = "1.png",
                    PricePerHour = 400,
                    UserId = "teacher1",
                    IsHome = true

                },
                     new Teacher
                     {
                         Id = 2,
                         FirstName = "Hande",
                         LastName = "Karakaya",
                         Location = "İstanbul",
                         Gender = "Kadın",
                         About = "Edebiyat Öğretmeni",
                         Url = "hande-karakaya",
                         ImageUrl = "2.png",
                         PricePerHour = 300,
                         UserId = "teacher2",
                         IsHome = true

                     },
                            new Teacher
                            {
                                Id = 3,
                                FirstName = "Harun",
                                LastName = "Kara",
                                Location = "İstanbul",
                                Gender = "Erkek",
                                About = "Almanca Öğretmeni",
                                Url = "harun-kara",
                                ImageUrl = "3.png",
                                PricePerHour = 300,
                                UserId = "teacher3",
                                IsHome = true

                            }



            );
        }
    }
}
