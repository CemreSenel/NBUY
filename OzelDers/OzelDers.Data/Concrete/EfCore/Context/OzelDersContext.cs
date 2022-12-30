using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Config;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Concrete.EfCore.Context
{
    public class OzelDersContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentTeacher> StudentTeachers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<University> Universities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OzelDers.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BranchConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new StudentTeacherConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new UniversityConfig());
        }
    }
}
