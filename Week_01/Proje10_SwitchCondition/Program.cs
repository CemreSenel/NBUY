namespace Proje10_SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // klavyeden  gırılen  sayının 5 olması halınde 2 katını , 10  olması halınde , 15 olması halınde 4 katını ekrana yazan program eger 3u de degılse tanınmayan deger yazsın.

            //Console.Write("sayıyı gırınız(5-10-15): ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;
            //if (sayi == 5)
            //{
            //    sonuc = sayi * 2;

            //}
            //else if (sayi == 10)
            //{
            //    sonuc = sayi * 3;

            //}
            //else if (sayi == 15)
            //{
            //    sonuc = sayi * 4;

            //}

            //if(sonuc == 0)
            //{
            //    Console.WriteLine("tanımlanmamıs deger");
            //}
            //else
            //{
            //    Console.WriteLine(sonuc);

            //}

            //Console.Write("sayıyı gırınız(5-10-15): ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;
            //switch (sayi)
            //{
            //    case 5:
            //        sonuc = sayi * 2;
            //        break;
            //    case 10:
            //        sonuc = sayi * 3;
            //        break;
            //    case 15:
            //        sonuc = sayi * 4;
            //        break;

            //    default:
            //        sonuc = 0;
            //        break;
            //}
            //if (sonuc == 0)
            //{
            //    Console.WriteLine("tanımlanmamıs deger");
            //}
            //else
            //{
            //    Console.WriteLine(sonuc);

            //}




            //int x = 11;
            //x 10  dan kucuk  ise *2
            // x  11 ile 20 *3
            // x  21 ile 50 *4
            // x  51 ile 100 *5
            // x  100 den buyuk ıse *10

            // cozum 1 if ile



            //int katsayi = 0;
            //if (x <= 10)
            //{
            //    katsayi = 2;
            //}
            //else if (x <= 20)
            //{
            //    katsayi = 3;
            //}
            //else if (x <= 50)
            //{
            //    katsayi = 4;
            //}
            //else if (x <= 100)
            //{
            //    katsayi = 5;
            //}
            //else
            //{
            //    katsayi = 10;
            //}
            //int sonuc = x * katsayi;
            //Console.WriteLine($"x: {x}, Sonuc: {x}x{katsayi}:{sonuc}");





            //     int x = 120;
            //     int katsayi = 0;
            //     switch (x)
            //     {
            //         case (>= 0 and <= 10):
            //             katsayi = 2;
            //             break;


            //}



            //içinde bulundugumuz gunun afta içi mi hafta sonu mu oldugunu bulma
            DateTime tarih = new DateTime(2022, 10, 8);
            DayOfWeek gun = tarih.DayOfWeek;
            //if (gun == DayOfWeek.Sunday || gun ==DayOfWeek.Saturday)
            //{
            //    Console.WriteLine("hafta sonundasın");

            //}
            //else
            //{
            //    Console.WriteLine("hafta ıcındesın");
            //}
            switch (gun)
            {
                case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday: 
                    case DayOfWeek.Wednesday:   
                    case DayOfWeek.Thursday:    
                    case DayOfWeek.Friday:
                    Console.WriteLine("hafta ıcındesın");
                    break;
                    case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:

                    Console.WriteLine("hafta sonundasın");
                    break;
                default:
                    break;
            }
        }
    }
}