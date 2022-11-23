using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KitabeviApp.ViewComponents
{
    public class YazarlarViewComponent : ViewComponent
    {
        KitabeviContext context = new KitabeviContext();
        public IViewComponentResult Invoke()
        {
            return View(context.Yazarlar.ToList());
        }
    }
}