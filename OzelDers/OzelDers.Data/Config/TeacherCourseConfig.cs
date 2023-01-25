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
    public class TeacherCourseConfig : IEntityTypeConfiguration<TeacherCourse>
    {
        public void Configure(EntityTypeBuilder<TeacherCourse> builder)
        {
            builder.HasKey(tb => new { tb.TeacherId, tb.CourseId });
            builder.ToTable("TeacherCourses");

            builder.HasData(
                new TeacherCourse { TeacherId = 1, CourseId = 1 },
                new TeacherCourse { TeacherId = 2, CourseId = 2 },
                new TeacherCourse { TeacherId = 3, CourseId = 3 }

                
                );
        }
    }
}
