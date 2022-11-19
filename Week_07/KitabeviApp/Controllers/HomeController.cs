using System.Diagnostics;
using KitabeviApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Index1()
    {
        KitabeviContext context = new KitabeviContext();
        List<Kategori> kategoriler = context.Kategoriler.ToList();
        return View(kategoriler);
    }


    public IActionResult Index2()
    {
        KitabeviContext context = new KitabeviContext();
        List<Yazar> yazarlar = context.Yazarlar.ToList();
        return View(yazarlar);
    }

    public IActionResult Index3()
    {
         KitabeviContext context = new KitabeviContext();
            List<Kitap> kitaplar= context
                .Kitaplar
                .Include(k=>k.Kategori)
                .Include(k=>k.Yazar)
                .ToList();
            return View(kitaplar);
    }
   
}
