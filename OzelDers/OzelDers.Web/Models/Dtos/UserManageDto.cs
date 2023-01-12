using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OzelDers.Web.Models.Dtos
{
    public class UserManageDto
    {
        public string Id { get; set; }
        [DisplayName("Ad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string LastName { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Gender { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public decimal? PricePerHour { get; set; }
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "{0} boş bırakılmamalı.")]
        public string UserName { get; set; }
    
    }
}
