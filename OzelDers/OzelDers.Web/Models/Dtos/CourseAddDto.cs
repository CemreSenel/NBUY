using OzelDers.Entity.Concrete;

namespace OzelDers.Web.Models.Dtos
{
    public class CourseAddDto
    {
        public int TeacherId { get; set; }
        public List<Branch> Branches { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? PricePerHour { get; set; }
        public int[] SelectedBranchId { get; set; }
    }
}
