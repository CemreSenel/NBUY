using OzelDers.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Entity.Concrete
{
    public class University : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
