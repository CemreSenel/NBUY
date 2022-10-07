namespace Proje14_Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = a * 2;
            Random rnd = new Random();
            Kisi kisi1 = new Kisi();
            
            kisi1.Ad = "cemre";
            kisi1.Yas = 27;
            kisi1.Meslek = "software";

            Kisi kisi2= new Kisi();
            kisi2.Ad = "cemal";
            kisi2.Yas = 25;
            kisi2.Meslek = "sair";


            Kisi kisi3 = new Kisi();
            kisi3.Ad = "saliha";
            kisi3.Yas = 25;
            kisi3.Meslek = "egıtmen";

            Araba araba1 = new Araba();
            araba1.Marka = "opel";
            araba1.Renk = "kırmızı";

            DateTime bugun = DateTime.Now;

            Random rnd2 = new Random();

        }
        class Kisi
        {
            public string? Ad { get; set; }
            public int Yas { get; set; }
            public string? Meslek { get; set; }

        }

        class Araba
        {
            public string Marka { get; set; }
            public string Renk { get; set; }
            string VitesTuru { get; set; }

            // Erişim belirleyıcı: Bir property nın dısarıdan yanı ıcınde bulundugu class ın dısından erısım sevıyesını belırleyen anahtar sozcuklere denır.eger herhangı bır erısım belırleyıcı kullanılmamıssa default erısım belırleyıcı prıvate kabul edılır.
            //erisim belirleyıcıler:
            //1:publıc  2: private   3 : internal   4:protected
        }
    }
}