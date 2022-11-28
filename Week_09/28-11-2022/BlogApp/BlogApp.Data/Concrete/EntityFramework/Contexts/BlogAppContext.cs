using BlogApp.Data.Concrete.EntityFramework.Mappings;
using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Contexts
{
    public class BlogAppContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OFVK2FD;Database=BlogAppDb;Integrated Security=true;TrustServerCertificate=true;");
        
            //EntityFrameworkCore 7 ile SqlServer veri tabanına baglantı ıle ılgılı onemlı bır degısıklık olmustur.Bu da guvenlık amacıyla dogrulanmıs sertıfıka gereksınımıdır. Bunu ifade eden TrustServerCertificate özelliği,böyle bir sertifika yoksa True ya cekılmelıdır,cunku default olarak false dur.False iken maalesef veritabanına baglansa bıle kullanıma izin vermez

            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
