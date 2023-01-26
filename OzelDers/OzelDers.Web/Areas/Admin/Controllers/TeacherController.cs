using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Core;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using OzelDers.Web.Areas.Admin.Models.Dtos;
using OzelDers.Web.Models.Dtos;
using System.Data;

namespace OzelDers.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IBranchService _branchService;
        private readonly UserManager<User> _userManager;

        public TeacherController(ITeacherService teacherService, IBranchService branchService, UserManager<User> userManager)
        {
            _teacherService = teacherService;
            _branchService = branchService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var teachers = await _teacherService.GetAllTeachersAsync();
            List<TeacherListDto> teacherListDto = new List<TeacherListDto>();
            foreach (var teacher in teachers)
            {
                teacherListDto.Add(new TeacherListDto
                {
                    Id = teacher.Id,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    PricePerHour = teacher.PricePerHour,
                    UserName = teacher.User.UserName,
                    Email = teacher.User.Email
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
                var url = Jobs.InitUrl(teacherAddDto.UserName);
                var teacher = new Teacher
                {
                    FirstName = teacherAddDto.FirstName,
                    LastName = teacherAddDto.LastName,
                    PricePerHour = teacherAddDto.PricePerHour,
                    User = new User
                    {
                        UserName = teacherAddDto.UserName,
                        Email = teacherAddDto.Email
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
                Id = teacher.Id,
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                PricePerHour = teacher.PricePerHour,
                UserName = teacher.User.UserName,
                Email = teacher.User.Email,
                Branches = await _branchService.GetAllAsync(),
                SelectedBranchIds = teacher.TeacherBranches.Select(tb => tb.BranchId).ToArray()
            };
            return View(teacherUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TeacherUpdateDto teacherUpdateDto, int[] selectedBranchIds)
        {
            if (ModelState.IsValid)
            {
                var teacher = await _teacherService.GetTeacherWithBranches(teacherUpdateDto.Id);
                if (teacher == null)
                {
                    return NotFound();
                }
                var url = Jobs.InitUrl(teacherUpdateDto.UserName);
                teacher.FirstName = teacherUpdateDto.FirstName;
                teacher.LastName = teacherUpdateDto.LastName;
                teacher.PricePerHour = teacherUpdateDto.PricePerHour;
                teacher.User.UserName = teacherUpdateDto.UserName;
                teacher.User.Email = teacherUpdateDto.Email;
                teacher.Url = url;
                await _teacherService.UpdateTeacherAsync(teacher, selectedBranchIds);
                return RedirectToAction("Index");
            }
            var branches = await _branchService.GetAllAsync();
            teacherUpdateDto.Branches = branches;
            return View(teacherUpdateDto);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var teacher = await _teacherService.GetTeacherWithBranches(id);
            if (teacher == null)
            {
                return NotFound();
            }
            _teacherService.Delete(teacher);
            await _userManager.DeleteAsync(teacher.User);
            return RedirectToAction("Index");
        }

       
    }

}