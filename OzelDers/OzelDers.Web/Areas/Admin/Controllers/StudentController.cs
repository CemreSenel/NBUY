using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Core;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using OzelDers.Web.Areas.Admin.Models.Dtos;

namespace OzelDers.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _studentService.GetAllStudentsAsync();
            var studentListDto = new List<StudentListDto>();
            foreach (var student in students)
            {
                studentListDto.Add(new StudentListDto
                {
                    Id=student.Id,
                    FirstName=student.FirstName,
                    LastName=student.LastName,
                    UserName=student.User.UserName,
                    Email=student.User.Email
                });
            }
            return View(studentListDto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentAddDto studentAddDto)
        {
            if (ModelState.IsValid)
            {
                var url = Jobs.InitUrl(studentAddDto.FirstName + "" + studentAddDto.LastName);
                var student = new Student
                {
                    FirstName = studentAddDto.FirstName,
                    LastName = studentAddDto.LastName,
                    User = new User
                    {
                        UserName = studentAddDto.UserName,
                        Email = studentAddDto.Email
                    }
                };
                await _studentService.CreateStudentAsync(student);
                return RedirectToAction("Index");
            }
            return View(studentAddDto);
        }


    }
}
