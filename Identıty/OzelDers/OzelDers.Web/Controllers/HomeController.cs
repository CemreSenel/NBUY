using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Entity.Concrete;
using OzelDers.Entity.Concrete.Identity;
using OzelDers.Web.Models.Dtos;

namespace OzelDers.Web.Controllers;

public class HomeController : Controller
{
    private readonly IUserService _userService;

    public HomeController(IUserService userService)
    {
        _userService = userService;
    }


    public async Task<IActionResult> Index()
    {
        List<User> users = await _userService.GetAllAsync();
        List<UserDto> userDtos = new List<UserDto>();
        foreach (var user in users)
        {
            userDtos.Add(new UserDto
            {
                ImageUrl = user.ImageUrl,
                FirstName = user.FirstName,
                LastName = user.LastName,   
                Age = user.Age,
                About = user.About,
                Branch = user.Branch
            });
        }

        return View(userDtos);
    }

}

