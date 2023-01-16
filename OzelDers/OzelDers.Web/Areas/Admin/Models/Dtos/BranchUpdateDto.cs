using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OzelDers.Web.Areas.Admin.Models.Dtos
{
    public class BranchUpdateDto
    {
        public int Id { get; set; }
        [DisplayName("Branş Adı")]
        [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
        public string Name { get; set; }

        [DisplayName("Branş Url")]
        [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
        public string Url { get; set; }
    }
}
