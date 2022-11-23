using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KitabeviApp.ViewComponents
{
    public class KategorilerViewComponent : ViewComponent 
    {
        KitabeviContext context = new KitabeviContext();
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["id"]!= null)
            {
                 ViewBag.SeciliKategori=int.Parse(RouteData.Values["id"].ToString());//RouteData.Values : Route ıd, action vb bilgileri tutuyor.Biz id'yi gönderiyoruz. 
            }
           
            return View(context.Kategoriler.ToList());
        }
    }
}