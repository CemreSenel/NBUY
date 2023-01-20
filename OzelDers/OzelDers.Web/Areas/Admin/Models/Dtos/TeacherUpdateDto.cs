using OzelDers.Entity.Concrete.Identity;
using OzelDers.Entity.Concrete;
using System.ComponentModel.DataAnnotations;

namespace OzelDers.Web.Areas.Admin.Models.Dtos
{
    public class TeacherUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? PricePerHour { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Branch> Branches { get; set; }
        public int[] SelectedBranchIds { get; set; }
    }
}
