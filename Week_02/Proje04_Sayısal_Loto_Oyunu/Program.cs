using System.Collections;

namespace Proje04_Sayısal_Loto_Oyunu
{

    internal class Program
    {
        static int[] SayiUret()
        {
            Random rnd = new Random();
            int[] loto = new int[6];
            int sayi;
            for (int i = 0; i < 6; i++)
            {

                do
                {
                    sayi = rnd.Next(1, 50);

                } while (loto.Contains(sayi));
                loto[i] = sayi;
            }
            return loto;
        }
        static void Hile(int[] loto)
        {
            Console.WriteLine("Hile");
            Console.WriteLine("*********");
            foreach (var siradakiSayi in loto)
            {
                Console.WriteLine(siradakiSayi);
            }
            Console.ReadLine();
        }

        static int TahminYap(int TahminSiraNo)//kulanıcının her tahmın yapısını burası yapacak
        {
            int tahmin;
            Console.Write($"{TahminSiraNo}. tahmininizi giriniz: ");
            tahmin = int.Parse(Console.ReadLine());
            return tahmin;

        }
        static void Main(string[] args)
        {
            #region Acılamalar
            // Sistem 1-49 arasında 6 tane farklı  sayı uretsın
            // kullanıcıdan 6 tane tahmın alalım
            // Sonuc olarak kullanıcının kac tane dogru tahmın yaptıgını, tahmınlerıyle bırlıkte yazdıralım
            // Hıc dogru tahmın yapamazsa KAYBETTINIZ yazsın.
            #endregion
            int[] loto = SayiUret();
            int[] tahminler = new int[6];
            Hile(loto);
            int tahmin;
            for (int i = 0; i < 6; i++)
            {
                do
                {
                    tahmin = TahminYap(i + 1);

                } while (tahmin < 0 || tahmin > 49);
                tahminler[i] = tahmin;

            }
            ArrayList bilinenler = new ArrayList();// Arraylistlerin kac elemanlı olacagı soylenmez.İçinde her bır eleman ıstenılen tıpte deger tutabılır. int , char vb.
            foreach (var siradakiTahmin in tahminler)
            {
                if (loto.Contains(siradakiTahmin)
                {
                    bilinenler.Add(siradakiTahmin);
                }
            }
            if (bilinenler.Count==0)
            {
                Console.WriteLine("kaybettınız, hiç bılemedınız");
            }
            else
            {
                Console.WriteLine($"tebrıkler, {bilinenler.Count} adet dogru tahmın yaptınız");
                Console.WriteLine("bıldıgınız sayılar: ");
                foreach (int siradakiBilinen in bilinenler)
                {
                    Console.WriteLine(siradakiBilinen);
                }   
            }

            


            Console.ReadLine();

        }

    }
}