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
    public class UniversityConfig : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.ToTable("Universities");

            builder.HasData(
                new University { Id=1,Name="Boğaziçi Üniversitesi"},
                new University { Id=2,Name="İstanbul Teknik Üniversitesi"},
                new University { Id=3,Name="Yıldız Teknik Üniversitesi"},
                new University { Id=4,Name="Anadolu Üniversitesi"},
                new University { Id=5,Name="Marmara Üniversitesi"},
                new University { Id=6,Name="İstanbul Üniversitesi"},
                new University { Id=7,Name="Kocaeli Üniversitesi"},
                new University { Id=8,Name="Sakarya Üniversitesi"},
                new University { Id=9,Name="Bahçeşehir Üniversitesi"},
                new University { Id=10,Name="Bilkent Üniversitesi"}


                );
        }
    }
}
