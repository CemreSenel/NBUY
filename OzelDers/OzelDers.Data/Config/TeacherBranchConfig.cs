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
    public class TeacherBranchConfig : IEntityTypeConfiguration<TeacherBranch>
    {
        public void Configure(EntityTypeBuilder<TeacherBranch> builder)
        {
            builder.HasKey(tb => new { tb.TeacherId, tb.BranchId });
            builder.ToTable("TeacherBranches");

            builder.HasData(
                new TeacherBranch { TeacherId=1,BranchId=1},
                new TeacherBranch { TeacherId=1,BranchId=2},
                new TeacherBranch { TeacherId=1,BranchId=3},
                new TeacherBranch { TeacherId=2,BranchId=4},
                new TeacherBranch { TeacherId=2,BranchId=5},
                new TeacherBranch { TeacherId=2,BranchId=6},
                new TeacherBranch { TeacherId=3,BranchId=7},
                new TeacherBranch { TeacherId=3,BranchId=8},
                new TeacherBranch { TeacherId=3,BranchId=9}




                );
        }
    }
}
