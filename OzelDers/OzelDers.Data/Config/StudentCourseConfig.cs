using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Config
{
    public class StudentCourseConfig : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(tb => new { tb.StudentId, tb.CourseId });
            builder.ToTable("StudentCourses");

            builder.HasData(
                new StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourse { StudentId = 2, CourseId = 2 },
                new StudentCourse { StudentId = 3, CourseId = 3 }

                );
        }
    }
}
