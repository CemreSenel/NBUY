namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string adSoyad = "Fatih Candan, Cemal Gündem, Selin Dilci";
            //string ad;
            //string[] adlar = new string[7];//içinde 3 adet string bılgı tutabılecek bır dızı
            //adlar[0] = "Fatih Candan";
            //adlar[1] = "Cemal Gündem";
            //adlar[2] = "Selin Dilci";
            //adlar[3] = "Kemal Kurt";
            //adlar[4] = "Begüm Yancı";
            //adlar[5] = "Selam Halıcı";
            //adlar[6] = "Emre Mor";
            ////Console.WriteLine(adlar[0]);

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    Console.WriteLine(adlar[i]);
            //}

            //int[] yaslar = new int[3];

            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //int toplam = 0;
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    toplam += rakamlar[i];
            //}
            //Console.WriteLine(toplam);

            //string okul = "Wissen Akademie";
            //Console.WriteLine(okul[8]);

            //CALISMA:klavyeden kullanıcının ad-soyad gırmesını ısteyınız.Girilen ad sayadı asagıya dogru buyuk harflarle yazdırınız.

            //Console.Write("Lütfen adınızı giriniz: ");
            //string ad = Console.ReadLine().ToUpper();
            //for (int i = 0;i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);
            //}

            //Console.WriteLine("bir metin giriniz: ");
            //string girilenMetin = Console.ReadLine().ToLower();
            //Console.Write("hangi karakterın sırasını bulmamızı ıstersınız: ");
            //string karakter = Console.ReadLine().ToLower();
            //int siraNo = girilenMetin.IndexOf(karakter) + 1;
            //Console.Clear();
            //Console.WriteLine($"Girilen Metin: {girilenMetin}\nAradıgınız karaker: {karakter}\nAradıgınız karakterin girilen metındekı sırası: {siraNo}  ");



            //Console.WriteLine("dızının orjınal halı");
            //Console.WriteLine("********************");
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            // Kendımız en buyuk sayıyı buluyoruz
            //int enBuyuk = rakamlar[0];
            //int enkucuk = rakamlar[0];
            //for (int i = 1; i < rakamlar.Length; i++)
            //{
            //    if (rakamlar[i] > enBuyuk)
            //    {
            //        enBuyuk = rakamlar[i];  
            //    }
            //    if(rakamlar[i] < enkucuk)
            //    {
            //        enkucuk = rakamlar[i];  
            //    }   
            //}
            //Console.WriteLine(enBuyuk);
            //Console.WriteLine(enkucuk);
            //****************************************************
            //istege baglı calısma odevi: bu diziyi kucukten buyuge sıralayınız
            //****************************************************
            //Console.WriteLine($"En Küçük:\t{rakamlar.Min()}");
            //Console.WriteLine($"En Küçük:\t{rakamlar.Max()}");

            //Console.WriteLine("dızının ters cevrılmıs halı");
            //Console.WriteLine("****************************");
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();



            //Console.WriteLine("dızının kucukten buyuge sıralanmıs halı:");
            //Console.WriteLine("****************************************");
            //Array.Sort(rakamlar);   //sort default olarak kucukten buyuge sıralar
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();



            //Console.WriteLine("dızının  buyukten kucuge sıralanmıs halı:");
            //Console.WriteLine("****************************************");
            //Array.Sort(rakamlar);   //sort default olarak kucukten buyuge sıralar
            //Array.Reverse(rakamlar);
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.eleman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();



            //ornekler::
            //ÖRNEK 1:
            //sayılar dızısının elemanlarının ortalamasını
            //int[] sayilar = { 5,-16,8,12,-15,78,90,0 };
            //int toplam = sayılar.Sum();
            //Console.WriteLine(toplam);
            //ornek2
            //sayılar dızısındekı cıft sayıları ekrana yazdıralım
            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    if (sayılar[i] % 2 == 0)
            //    {
            //        Console.WriteLine(sayılar[i]);
            //    }
            //}
            //örnek 3
            //sayılar dızısındekı sayıları yanlarında pozıtıf,negatıf ya da isaretsız olma bılgılerıyle yazdıralım
            //string tip ="";
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    tip = sayilar[i] > 0 ? "pozıtıf" : sayilar[i] < 0 ? "negatıf" : "isaretsız";
            //    Console.WriteLine($"{i + 1}. sayı: {sayilar[i]}-tipi: {tip}");
            //}

            //ornek4
            //kullanıcıının girecegı bır metnın ıcındekı seslı harf sayısını ekrana yazdıralım

            //char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //int sesliHarfAdedi = 0;
            //Console.Write("Bir metin giriniz: ");
            //string girilenMetin = Console.ReadLine().ToLower();
            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if (sesliHarfler.Contains(girilenMetin[i]))
            //    {
            //        sesliHarfAdedi ++;
            //    }
            //}
            //Console.WriteLine(sesliHarfAdedi);


            //örnek5
            //klavyeden gırılen bır cumledekı yıne klavyeden gırılecek bır kelımemnın kac kec gectıgını bulduralım.

            //string ornekMetin = "Cemre Şenel Fenerbahçe";
            //string[] sozcukDizisi = ornekMetin.Split(" ");
            //for (int i = 0; i < sozcukDizisi.Length; i++)
            //{
            //    Console.WriteLine(sozcukDizisi[i]);
            //}

            int sozcukAdedi = 0;
            Console.Write("cumleyı gırınız: ");
            string girilenCumle = Console.ReadLine();
            Console.Write("adedeını bulmak ıstedıgınız sozcugu gırınız: ");
            string sayilacakSozcuk=Console.ReadLine();
            string[] girilenCumleninDiziHali = girilenCumle.Split(" ");
            for (int i = 0; i < girilenCumleninDiziHali.Length; i++)
            {
                if (sayilacakSozcuk.ToLower() == girilenCumleninDiziHali[i].ToString().ToLower())
                        {
                sozcukAdedi++;
                        }
            }
            Console.WriteLine($"{girilenCumle} cumlesı ıcınde {sayilacakSozcuk} sozcugu {sozcukAdedi} kez gecmektedır");
            //****************************
            //ARASTIRMA ODEVI: cok boyutlu dızılerı arastırın 
            //****************************
            


            //PROJE ODEVI
            //İcınde turkce karakterler harıc tum kucuk harflar,0-9 arası rakamlar,nokta(.),virgül(,),art(+),eksi(-) karakterleri bulunabılecek toplam uzunlugu 6 karakter olacak sekılde rastgele sifre ureten programı yazınız.

            //engin.ergul@wissenakademie.com
        }
    }
}