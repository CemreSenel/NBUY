using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Proje04_MVC.Controllers;
 public class Product{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Category{
    public int Id { get; set; }
    public string Name { get; set; }
}

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

    public IActionResult About()
    {
        ViewBag.Hata=false;
        ViewData["Not"]=75;
        List<string> adlar = new List<string>(){"Sema","Harun","Sefa",""};
        ViewData["Adlar"]=adlar;

         List<string> bolumler = new List<string>(){"Muhasebe","İnsan Kaynakları"};
        ViewBag.Bolumler=bolumler;

        return View();
    }

    public IActionResult GetProducts()
    {
        List<Product> products = new List<Product>(){
            new Product (){Id=1,Name="IPhone",Price=24000},
            new Product (){Id=2,Name="IPhone",Price=15000},
            new Product (){Id=3,Name="IPhone",Price=44000},
            new Product (){Id=4,Name="IPhone",Price=55000},
            new Product (){Id=5,Name="IPhone",Price=24000}
        };
        // ViewBag.Products=products;
        return View(products);
    }

    public IActionResult GetCategories()
    {
        List<Category> categories = new List<Category>(){
            new Category(){Id=1,Name="Phone"},
            new Category(){Id=2,Name="Computer"},
            new Category(){Id=3,Name="Electronıc"}
            
        };
        return View(categories);
    }


    
}
