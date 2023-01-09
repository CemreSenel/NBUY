using Microsoft.AspNetCore.Identity;
using OzelDers.Entity.Abstract;
using OzelDers.Entity.Concrete.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Entity.Concrete
{
    public class Teacher : IEntityBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Gender { get; set; }
        public string About { get; set; }
        public decimal? PricePerHour { get; set; }
        public int BranchId { get; set; }
        public Branch Branch   { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public bool IsHome { get; set; } 
    }
}
