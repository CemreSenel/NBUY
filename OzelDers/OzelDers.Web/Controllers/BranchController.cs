using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Entity.Concrete;
using OzelDers.Web.Models.Dtos;

namespace OzelDers.Web.Controllers
{
    public class BranchController : Controller
    {
        private readonly ITeacherService _teacherService;

        public BranchController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BranchList(string branchurl)
        {
            List<Teacher> teachers = await _teacherService.GetTeachersByBranchAsync(branchurl);
            List<TeacherDto> teacherDtos = new List<TeacherDto>();
            foreach (var teacher in teachers)
            {
                teacherDtos.Add(new TeacherDto
                {
                    Id = teacher.Id,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    ImageUrl = teacher.ImageUrl,
                    Url = teacher.Url,
                    Location = teacher.Location,
                    PricePerHour = teacher.PricePerHour
                });
            }
            return View(teacherDtos);
        }
    }
}
