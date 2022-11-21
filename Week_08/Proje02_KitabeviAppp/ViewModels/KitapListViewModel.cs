using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Proje02_KitabeviAppp.ViewModels
{
    public class KitapListViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int BasimYili { get; set; }
        public int SayfaSayisi { get; set; }
        public int KategoriId { get; set; }

        public int YazarId { get; set; }

    }
}