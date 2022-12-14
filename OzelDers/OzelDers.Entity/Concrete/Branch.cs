using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Entity.Concrete
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public List<Teacher> Teachers { get; set; }
        public List<TeacherBranch> TeacherBranches { get; set; }

    }
}
