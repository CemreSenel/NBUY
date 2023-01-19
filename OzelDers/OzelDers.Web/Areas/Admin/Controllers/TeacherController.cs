using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Core;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using OzelDers.Web.Areas.Admin.Models.Dtos;

namespace OzelDers.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IBranchService _branchService;

        public TeacherController(ITeacherService teacherService, IBranchService branchService)
        {
            _teacherService = teacherService;
            _branchService = branchService;
        }

        public async Task<IActionResult> Index()
        {
            var teachers = await _teacherService.GetAllTeachersAsync();
            List<TeacherListDto> teacherListDto = new  List<TeacherListDto>();
            foreach (var teacher in teachers)
            {
                teacherListDto.Add(new TeacherListDto
                {
                    Id= teacher.Id,
                    FirstName= teacher.FirstName,
                    LastName= teacher.LastName,
                    PricePerHour= teacher.PricePerHour,
                    UserName= teacher.User.UserName,
                    Email= teacher.User.Email
                });
            }
            return View(teacherListDto);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var branches = await _branchService.GetAllAsync();
            var teacherAddDto = new TeacherAddDto
            {
                Branches = branches
            };
            return View(teacherAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TeacherAddDto teacherAddDto)
        {
            if (ModelState.IsValid)
            {
                var url = Jobs.InitUrl(teacherAddDto.FirstName + "" + teacherAddDto.LastName);
                var teacher = new Teacher
                {
                  FirstName=teacherAddDto.FirstName,
                  LastName=teacherAddDto.LastName,
                  PricePerHour=teacherAddDto.PricePerHour,
                  User= new User
                  {
                      UserName=teacherAddDto.UserName,
                      Email=teacherAddDto.Email
                  }
                };
                await _teacherService.CreateTeacherAsync(teacher, teacherAddDto.SelectedBranchIds);
                return RedirectToAction("Index");
            }
            var branches = await _branchService.GetAllAsync();
            teacherAddDto.Branches = branches;
            return View(teacherAddDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var teacher = await _teacherService.GetTeacherWithBranches(id);
            TeacherUpdateDto teacherUpdateDto = new TeacherUpdateDto
            {
                
              
                Branches = await _branchService.GetAllAsync(),
                SelectedBranchIds = teacher.TeacherBranches.Select(tb => tb.BranchId).ToArray()
            };
            return View(teacherUpdateDto);
        }
    }
}
