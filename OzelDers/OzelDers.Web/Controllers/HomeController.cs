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
        List<Teacher> teachers = await _teacherService.GetHomePageTeachersAsync();
        List<TeacherDto> teacherDtos = new List<TeacherDto>();
        foreach (var teacher in teachers)
        {
            teacherDtos.Add(new TeacherDto
            {
                Id= teacher.Id, 
                FirstName= teacher.FirstName,   
                LastName= teacher.LastName, 
                Location= teacher.Location, 
                Url= teacher.Url,   
                PricePerHour= teacher.PricePerHour
            });
        }
        return View(teacherDtos);  
    }
 

    
}
