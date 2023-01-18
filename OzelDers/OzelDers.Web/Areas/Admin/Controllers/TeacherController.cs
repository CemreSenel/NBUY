using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Web.Areas.Admin.Models.Dtos;

namespace OzelDers.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        public async Task<IActionResult> Index()
        {
            var teachers = await _teacherService.GetAllTeacherAsync();
            List<TeacherListDto> teacherListDto = new  List<TeacherListDto> ();
            foreach (var teacher in teachers)
            {
                teacherListDto.Add(new TeacherListDto
                {
                    Id= teacher.Id,
                    FirstName= teacher.FirstName,
                    LastName= teacher.LastName,
                    PricePerHour= teacher.PricePerHour,
                    UserName= teacher.User.UserName,
                    Eamil= teacher.User.Email
                });
            }
            return View(teacherListDto);
        }
    }
}
