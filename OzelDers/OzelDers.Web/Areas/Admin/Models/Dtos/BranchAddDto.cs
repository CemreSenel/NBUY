using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OzelDers.Web.Areas.Admin.Models.Dtos
{
    public class BranchAddDto
    {
        [DisplayName("Branş Adı")]
        [Required(ErrorMessage = "{0} boş bırakılmamalıdır.")]
        public string Name { get; set; }
    }
}
