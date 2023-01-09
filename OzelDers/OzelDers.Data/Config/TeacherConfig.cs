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
                    BranchId=1,
                    UserId="teacher",
                    IsHome=true

                }
               

            );
        }
    }
}
