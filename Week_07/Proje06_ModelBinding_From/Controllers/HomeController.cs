using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_ModelBinding_From.Models;

namespace Proje06_ModelBinding_From.Controllers;

public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult YasGrubu()
    {
        return View();
    }

    [HttpPost]
    public IActionResult YasGrubu(int yas,string ad)
    {
        if (yas==0)
        {
            ViewBag.YasGrubu="Lütfen bır yas bılgısı gırınız";
        }
        else if (yas<18)
        {
            ViewBag.YasGrubu=$"{ad}, resit degılsınız";
        }
        else if(yas<40)
        {
            ViewBag.YasGrubu= $"{ad}, gencsınız";

        }
        else if(yas<60)
        {
            ViewBag.YasGrubu= $"{ad}, genclere tas cıkarırsınız";

        }else{
            ViewBag.YasGrubu= $"{ad}, hala emeklı olmadınız mı";

        }
        return View();
    }

    public IActionResult CreateProduct()
    {
        return View();
    }

    [HttpPost]

    public IActionResult CreateProduct(Product product)
    {
        //Burada veri tabanına kayıt ıslemı vb. yapılacak.
        //Şimdilik biz gelen verılerın testını yapabılmek ıcın tekrar sayfaya bastıralım
        // ViewBag.ResultHeader =$"{product.Name} adlı urun eklendı";
        // ViewBag.ResultBody =$"Category: {product.Category}, Price: {product.Price}";
        return View(product);
    }





    // public IActionResult VerileriAl(string txtAd,int txtYas)
    // {
    //     return View();
    // }
}
