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
    public class BranchConfig : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Url)
                .IsRequired()
                .HasMaxLength(250);

            builder.ToTable("Branches");

            builder.HasData(

                new Branch { Id = 1, Name = "Matematik", Url = "matematik" },
                new Branch { Id = 2, Name = "Kimya", Url = "kimya" },
                new Branch { Id = 3, Name = "Fizik", Url = "fizik" },
                new Branch { Id = 4, Name = "Biyoloji", Url = "biyoloji" },
                new Branch { Id = 5, Name = "Tarih", Url = "tarih" },
                new Branch { Id = 6, Name = "Edebiyat", Url = "edebiyat" },
                new Branch { Id = 7, Name = "Almanca", Url = "almanca" },
                new Branch { Id = 8, Name = "İngilizce", Url = "ingilizce" },
                new Branch { Id = 9, Name = "Coğrafya", Url = "cografya" },
                new Branch { Id = 10, Name = "Bilgisayar", Url = "bilgisayar" }

            );

        }
    }
}
