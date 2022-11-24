using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Business.Abstract;
using KitabeviApp.Data.EfCore.Concrete;
using KitabeviApp.Entity;

namespace KitabeviApp.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        public void KategoriEkle(Kategori kategori)
        {
            var kategoriRepository = new EfCoreKategoriRepository();
            kategoriRepository.Ekle(kategori);
        }

        public void KategoriGuncelle(Kategori kategori)
        {
            var kategoriRepository = new EfCoreKategoriRepository();
            kategoriRepository.Guncelle(kategori);
        }

        public Kategori KategoriGetir(int id)
        {
            var kategoriRepository = new EfCoreKategoriRepository();
            return kategoriRepository.Getir(id);
        }

        public List<Kategori> KategoriListele()
        {
            var kategoriRepository = new EfCoreKategoriRepository();
            return kategoriRepository.Listele();
        }

        public void KategoriSil(Kategori kategori)
        {
            var kategoriRepository = new EfCoreKategoriRepository();
            kategoriRepository.Sil(kategori);
        }

      
    }
}