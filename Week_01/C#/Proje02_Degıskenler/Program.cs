namespace Proje02_Degıskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bir degışkene isim verılırken;
            //1) alfanumerık karakterler kullanılmaz( _ haric)
            //2) turkce karakter kullanılmaz(zorunlu degıl)
            //3) ozel ya da ayrılmıs sozcukler kullanılmaz
            //4) degısken ısımlerı kucuk-buyuk harf duyarlıdır.
            /*
            string adSoyad;
            adSoyad = "Alex de Souza";
            Console.WriteLine(adSoyad);
            Console.WriteLine("adSoyad");
            */

            //int yas;
            //yas = 19;
            //Console.WriteLine(yas);

            //string adSoyad = "Ahmet Candan";
            //Console.WriteLine(adSoyad);

            //Console.WriteLine("Adı:" + adSoyad + ", Yaş:" + yas);


            // TAM SAYI
            //Console.WriteLine(int.MinValue +  "-" + int.MaxValue);
            byte sayi1 = 45;
            int sayi2 = 15611515; 
            long sayi3 = 123546879531;

            //string sayi4 = "15";
            //Console.WriteLine(sayi4 + 2);

            // ONDALIKLI SAYILAR
            float a = 10.5f;
            double b = 20.6;
            decimal c = 100.65m;


            // KARAKTER VE METİN
            string name = "Cemre Senel";
            char cinsiyet = 'E';

            // MANTIKSAL
            bool evliMi = true;
            evliMi = false;

        }
    }
}