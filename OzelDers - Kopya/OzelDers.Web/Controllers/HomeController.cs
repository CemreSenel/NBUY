using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Entity.Concrete;
using OzelDers.Web.Models.Dtos;

namespace OzelDers.Web.Controllers;

public class HomeController : Controller
{
    private readonly ITeacherService _teacherService;

    public HomeController(ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    public async Task<IActionResult> Index()
    {
        List<Teacher> teachers = await _teacherService.GetAllAsync();
        List<TeacherDto> teacherDtos = new List<TeacherDto>();
        foreach (var teacher in teachers)
        {
            teacherDtos.Add(new TeacherDto
            {
                Id = teacher.Id,
                FirstName= teacher.FirstName,
                LastName= teacher.LastName,
                Age = teacher.Age,
                About= teacher.About,
                Branch= teacher.Branch
            });
        }

        return View(teacherDtos);
    }

    
}
