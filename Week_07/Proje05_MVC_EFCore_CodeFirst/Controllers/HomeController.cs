﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje05_MVC_EFCore_CodeFirst.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }

    

    
}
