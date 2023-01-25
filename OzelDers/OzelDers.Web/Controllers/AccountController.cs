using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Core;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using OzelDers.Web.Models.Dtos;
using System.Data;

namespace OzelDers.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITeacherService _teacherService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, ITeacherService teacherService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _teacherService = teacherService;
        }


        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto, string membershipType)
        {
            if (ModelState.IsValid)
            {
                if (membershipType == "teacher")
                {
                    var user = new User
                    {
                        UserName = registerDto.UserName,
                        Email = registerDto.Email,
                        Teachers = new Teacher
                        {
                            FirstName = registerDto.FirstName,
                            LastName = registerDto.LastName

                        }

                    };
                    var result = await _userManager.CreateAsync(user, registerDto.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Teacher");
                    }
                }
                else
                {
                    var user = new User
                    {
                        UserName = registerDto.UserName,
                        Email = registerDto.Email,
                        Students = new Student
                        {
                            FirstName = registerDto.FirstName,
                            LastName = registerDto.LastName
                        }
                    };
                    var result = await _userManager.CreateAsync(user, registerDto.Password);
                    if (result.Succeeded)
                    {
                        await _userManager.AddToRoleAsync(user, "Student");
                    }
                }
            }
            return RedirectToAction("Login", "Account");

        }

        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginDto { ReturnUrl = returnUrl });

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(loginDto.UserName);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı!");
                    return View(loginDto);
                }

                var result = await _signInManager.PasswordSignInAsync(user, loginDto.Password, true, true);
                if (result.Succeeded)
                {
                    return Redirect(loginDto.ReturnUrl ?? "~/");
                }
                ModelState.AddModelError("", "Kullanıcı adı ya da parola hatalı!");
            }
            return View(loginDto);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Manage(string id)
        {
            var name = id;
            if (String.IsNullOrEmpty(name))
            {
                return NotFound();
            }
            var user = _teacherService.GetUser(name, "");
            if (user == null) { return NotFound(); }
            UserManageDto userManageDto = new UserManageDto();
            if (User.IsInRole("Teacher"))
            {
                userManageDto.Id = user.Id;
                userManageDto.FirstName = user.Teachers.FirstName;
                userManageDto.LastName = user.Teachers.LastName;
                userManageDto.Email = user.Email;
                userManageDto.UserName = user.UserName;
            }
            else if (User.IsInRole("Student"))
            {
                userManageDto.Id = user.Id;
                userManageDto.FirstName = user.Students.FirstName;
                userManageDto.LastName = user.Students.LastName;
                userManageDto.Email = user.Email;
                userManageDto.UserName = user.UserName;
            }
            userManageDto.Id = user.Id;
            userManageDto.UserName = user.UserName;
            userManageDto.Email = user.Email;
            return View(userManageDto);
        }

        [HttpPost]
        public async Task<ActionResult> Manage(UserManageDto userManageDto)
        {
            if (userManageDto == null)
            {
                return NotFound();
            }
            var user = _teacherService.GetUser("", userManageDto.Id);
            if (User.IsInRole("Teacher"))
            {
                if (user == null)
                {
                    return NotFound();
                }
                user.Teachers.FirstName = userManageDto.FirstName;
                user.Teachers.LastName = userManageDto.LastName;
                user.UserName = userManageDto.UserName;
                user.Email = userManageDto.Email;
            }
            else if (User.IsInRole("Student"))
            {
                if (userManageDto == null)
                {
                    return NotFound();
                }
                user.Students.FirstName = userManageDto.FirstName;
                user.Students.LastName = userManageDto.LastName;
                user.Email = userManageDto.Email;
                user.UserName = userManageDto.UserName;
            }
            user.UserName = userManageDto.UserName;
            user.Email = userManageDto.Email;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index", "Home");
        }

      
        public Task<IActionResult> AddCourse(int id)
        {

        }
        
    }
}
