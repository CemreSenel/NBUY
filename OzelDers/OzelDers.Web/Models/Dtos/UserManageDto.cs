namespace OzelDers.Web.Models.Dtos
{
    public class UserManageDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Gender { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public decimal? PricePerHour { get; set; }
        public string UserName { get; set; }
    }
}
