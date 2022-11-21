using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje02_KitabeviAppp.Models;

namespace Proje02_KitabeviAppp.ViewModels
{
    public class KitapViewModel
    {
        public Kitap Kitap { get; set; }//return View icin
        public List<Yazar> Yazarlar { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}