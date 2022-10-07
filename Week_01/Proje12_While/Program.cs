namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
        // int sayac=1;
        // while (sayac<=5)
        // {
        //     Console.WriteLine("Hello, World!");
        //     sayac++;
        // }

        // int toplam=0;
        // string girilendeger="";
        // int sayac=1;

        // while (girilendeger !="exit")
        // {
        //   Console.Write($" {sayac} .sayıyı giriniz(cıkıs için exit): " );
        //     girilendeger=Console.ReadLine();
        //     // if(girilendeger!="exit");
        //    try
        //    {
        //      toplam += Convert.ToInt32(girilendeger);
        //    }
        //    catch (System.Exception)
        //    {
        //     Console.WriteLine(toplam);
        //     break;
        //    }
        //     sayac++;

        // }


        //SORU: klavyeden exıt yazılana kadar isim girilmesini isteyen program
         //cozum1
        // string isim="";
        // while (isim!="exit");
        // {
        //     Console.Write("isim giriniz: ");
        //     isim =Console.ReadLine();
        // }
        // Console.WriteLine("program sona eri...");

        //cozum2

        // string isim;
        // do
        // {
        //     Console.Write("isim giriniz: ");
        //     isim =Console.ReadLine();
        // } while (isim!="exit");
        // Console.WriteLine("program sona erdi..");



        //Klavyedden exıt yazılana kadar sayı almaya devam eden ve bu sayıların toplamını exıt yazılınca ekrana yazan program
        // string girilenDeger;
        // int sayac=1;
        // int toplam=0;
        // do
        // {
        //     Console.Write($" {sayac} .sayıyı giriniz(cıkıs için exit): " );
        //     girilenDeger=Console.ReadLine();
        //     if(girilenDeger!="exit") toplam +=Convert.ToInt32(girilenDeger);
        // } while (girilenDeger!="exit");

        // Random rastgele = new Random();
        // int rastgeleSayi=rastgele.Next();
        // Console.WriteLine(rastgeleSayi);
        // int rastgeleSayı2=rastgele.Next(100);//0-100 arsında rastgele sayı uretir.0 dahıl. 100 harıctır.
        // Console.WriteLine(rastgeleSayı2);
        //  int rastgeleSayı3=rastgele.Next(1000,2000);//10000 dahıl 2000 dahıl degıldır.
        // Console.WriteLine(rastgeleSayı3);

        //OYUN: Uygulamanın rastgele uretecegı bır sayıyı kullanıcının tahmın etmesını ısteyecegız.
        //rastgele uretılecek olan sayı 1-100 arasında olsun.
        //kullanıcı rastgele sayıdan kucuk ya da buyuk bir sayı gırdıgınde kullanıcı uygun bır sekılde uyarılsın
        //dogru sayıyı gırene kadar uygulama calıssın.(x)
        //kullanıcı dogru sayıyıtahmın ettıyse ya da 5 hakkını gırdıyse uygulama sona ersın

        Random rnd=new Random();
        int uretilenSayi=rnd.Next(1,101);
        Console.WriteLine($"hıle: {uretilenSayi}");
        int tahminedilenSayı;
        int hak=1;//kullanıcının o sırada kacıncı hakkını kullandıgı bılgısı
        int hakSiniri=5;//kullanıcının toplam kac hakka sahıp oldugu bılgısı
      //   do
      //   {
      //   Console.Write($"{hak}.Tahmınınızı gırınız: ");
      //    tahminedilenSayı=Convert.ToInt32(Console.ReadLine());
         
      //    if (hak==hakSiniri && uretilenSayi!=tahminedilenSayı)
      //    {
      //       Console.WriteLine("kaybettınız");
      //       break;
      //    }
         
      //       if (tahminedilenSayı>uretilenSayi)
      //    {
      //       Console.WriteLine("buyuk bır deger girdınız daha kucuk bir deger gırınız");
      //    }
      //    else if(tahminedilenSayı<uretilenSayi)
      //    {
      //       Console.WriteLine("kucuk bır deger girdınız daha kucuk bir deger gırınız");
            
      //    }else
      //    {
      //       Console.WriteLine("tebrıkler kazandınız");
            
      //    }  
      //    hak++;
         
      //   } 
      //   while (tahminedilenSayı != uretilenSayi && hak<=hakSiniri);
            do
            {
               Console.Write($"{hak}.Tahmınınızı gırınız: ");
         tahminedilenSayı=Convert.ToInt32(Console.ReadLine());
               if (tahminedilenSayı>uretilenSayi)
               {
                  Console.WriteLine("buyuk gırdın");
               }else if (tahminedilen)
               {
                  
               }
            } while (tahminedilenSayı=uretilenSayi && hak<=hakSiniri );
         //eger program bu satıra gelmıs ise ya dogru tahmınde bulunulmustur ya da hak bıtmıstır.

    }
}
