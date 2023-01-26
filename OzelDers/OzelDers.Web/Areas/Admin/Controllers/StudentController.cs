using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Core;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using OzelDers.Web.Areas.Admin.Models.Dtos;
using System.Data;

namespace OzelDers.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly UserManager<User> _userManager;

        public StudentController(IStudentService studentService, UserManager<User> userManager)
        {
            _studentService = studentService;
            _userManager = userManager;
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id) 
        {
            var student = await _studentService.GetStudentWithUser(id);
            StudentUpdateDto studentUpdateDto = new StudentUpdateDto
            {
                Id = student.Id,
                FirstName = student.FirstName,
                LastName=student.LastName,
                UserName=student.User.UserName,
                Email=student.User.Email
            };
            return View(studentUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StudentUpdateDto studentUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var student = await _studentService.GetStudentWithUser(studentUpdateDto.Id);
                if (student == null)
                {
                    return NotFound();
                }
                var url = Jobs.InitUrl(studentUpdateDto.UserName);
                student.FirstName = studentUpdateDto.FirstName;
                student.LastName = studentUpdateDto.LastName;
                student.User.UserName = studentUpdateDto.UserName;
                student.User.Email = studentUpdateDto.Email;
                student.Url = url;
                _studentService.Update(student);
                return RedirectToAction("Index");
            }
            return View(studentUpdateDto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var student = await _studentService.GetStudentWithUser(id);
            if (student == null) { return NotFound(); }
            _studentService.Delete(student);
            await _userManager.DeleteAsync(student.User);
            return RedirectToAction("Index");
        }
    }
}

