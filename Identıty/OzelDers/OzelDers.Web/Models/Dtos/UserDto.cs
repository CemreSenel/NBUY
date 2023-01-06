using OzelDers.Entity.Concrete;

namespace OzelDers.Web.Models.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string ImageUrl { get; set; }
        public string About { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

    }
}
