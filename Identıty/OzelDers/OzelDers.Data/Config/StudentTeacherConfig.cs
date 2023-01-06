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
    public class StudentTeacherConfig : IEntityTypeConfiguration<StudentTeacher>
    {
        public void Configure(EntityTypeBuilder<StudentTeacher> builder)
        {
            builder.HasKey(st => new { st.StudentId, st.TeacherId });

            builder.ToTable("StudentTeachers");

            builder.HasData(
                new StudentTeacher { StudentId=1,TeacherId=1},
                new StudentTeacher { StudentId=1,TeacherId=2},
                new StudentTeacher { StudentId=1,TeacherId=3},

                new StudentTeacher { StudentId=2,TeacherId=2},
                new StudentTeacher { StudentId=2,TeacherId=4},
                new StudentTeacher { StudentId=2,TeacherId=6},

                new StudentTeacher { StudentId=3,TeacherId=5},
                new StudentTeacher { StudentId=3,TeacherId=7},
                new StudentTeacher { StudentId=3,TeacherId=8},

                new StudentTeacher { StudentId=4,TeacherId=5},
                new StudentTeacher { StudentId=4,TeacherId=9},
                new StudentTeacher { StudentId=4,TeacherId=10},

                new StudentTeacher { StudentId=5,TeacherId=4},
                new StudentTeacher { StudentId=5,TeacherId=7},
                new StudentTeacher { StudentId=5,TeacherId=9}


                );
        }
    }
}
