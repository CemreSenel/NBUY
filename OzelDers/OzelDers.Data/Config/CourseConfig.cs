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
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();


            builder.ToTable("Courses");

            builder.HasData(

                new Course { Id = 1, Name = "Matematik",Description="Matematik dersi", Url = "matematik" ,PricePerHour=500,BranchId=1},
                new Course { Id = 2, Name = "Kimya",Description="Kimya dersi", Url = "kimya",PricePerHour=400 ,BranchId=2},
                new Course { Id = 3, Name = "Fizik",Description="Fizik dersi", Url = "fizik",PricePerHour=300,BranchId=3 }
            );
        }
    }
}
