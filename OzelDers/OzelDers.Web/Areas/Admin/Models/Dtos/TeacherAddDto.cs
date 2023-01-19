using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using System.ComponentModel.DataAnnotations;

namespace OzelDers.Web.Areas.Admin.Models.Dtos
{
    public class TeacherAddDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? PricePerHour { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Branch> Branches { get; set; }
        [Required(ErrorMessage = "En az bir branş seçilmelidir.")]
        public int[] SelectedBranchIds { get; set; }
        public User User { get; set; }
    }
}
