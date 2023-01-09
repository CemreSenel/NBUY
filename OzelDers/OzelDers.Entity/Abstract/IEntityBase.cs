using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Entity.Abstract
{
    public interface IEntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Gender { get; set; }
    }
}
