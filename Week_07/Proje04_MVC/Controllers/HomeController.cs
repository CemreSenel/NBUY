using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Proje04_MVC.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        string ad="Cemre";
        ViewBag.KisiAd=ad;
        string dil="en";
        string selamlama;
        selamlama="";
        if (dil=="Tr")
        {
            selamlama="Hosgeldınız";
        }else if(dil=="en")
        {
            selamlama="Welcome";
        }else{
            selamlama="";
        }
        ViewBag.Selam=selamlama;
        return View();
    }

    
}
