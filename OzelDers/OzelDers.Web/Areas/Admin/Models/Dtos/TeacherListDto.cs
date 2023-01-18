using OzelDers.Entity.Concrete.Identity;

namespace OzelDers.Web.Areas.Admin.Models.Dtos
{
    public class TeacherListDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? PricePerHour { get; set; }
        public string UserName { get; set; }
        public string Eamil { get; set; }
    }
}
