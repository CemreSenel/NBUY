using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);  //PrimaryKey olmasını sağlıyor.
            builder.Property(c => c.Id).ValueGeneratedOnAdd();//1den baslayıp 1 er 1er artmasını saglıyor Id nın.


            builder.Property(c => c.Name)
                .IsRequired()//Zorunlu olmasını saglıyor.
                .HasMaxLength(50);


            builder.Property(c => c.Description)
                .IsRequired()//Zorunlu olmasını saglıyor.
                .HasMaxLength(500);//Max uzunluk

            builder.Property(c => c.Url)
                .IsRequired()
                .HasMaxLength(250);

            builder.ToTable("Categories");//Veritanında olusmasını ıstedıgımız isim

            builder.HasData(
                new Category { Id = 1, Name = "Telefon", Description = "Telefonlar bu kategoride bulunmaktadır.", Url = "telefon" },
                new Category { Id = 2, Name = "Elektronik", Description = "Elektronik ürünler kategoride bulunmaktadır.", Url = "elektronik" },
                new Category { Id = 3, Name = "Bilgisayar", Description = "Bilgisayarlar bu kategoride bulunmaktadır.", Url = "bilgisayar" },
                new Category { Id = 4, Name = "Beyaz Eşya", Description = "Beyaz eşyalar bu kategoride bulunmaktadır.", Url = "beyaz-esya" }
                );
        }
    }
}
