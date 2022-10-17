namespace Proje09_IfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi=Convert.ToInt32(Console.ReadLine());   
            //if (sayi>=0)
            //{
            //    Console.WriteLine("merhaba dunya");
            //}
            // kullanıcıdan yasını gırmesını ısteyelım
            // 18 yasından kucuklaere "gırıs yasak" mesajını yazdıralım


            //Console.Write("Yaşınızı Giriniz: ");
            //byte yas=(Convert.ToByte(Console.ReadLine()));
            //if (yas < 18)
            //{
            //    Console.WriteLine("GİRİS YASAKTIR");  
            //}else if (yas > 18)
            //{
            //    Console.WriteLine("GİRİŞ SERBEST");
            //}
            //else
            //{
            //    Console.WriteLine("VELINLE BIRLIKTE GEL");  
            //}

            // girilen ıı sayıdan buyuk olanı yazdırın
            //Console.Write("1. sayıyı gır: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı gır: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if(sayi1> sayi2)
            //{
            //    Console.WriteLine($"Buyuk sayı: {sayi1}");
            //}else if (sayi2 > sayi1)
            //{
            //    Console.WriteLine($"Buyuk sayı: {sayi2} ");
            //}
            //else
            //{
            //    Console.WriteLine($"sayı 1 : ({sayi1}) ve sayı 2 ({sayi2}) bırbırlerıne esıttır ");

            //}
            //gırılen 3 sayıdan buyuk olanı yazdır
            //Console.Write("1. sayıyı gır: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı gır: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3. sayıyı gır: ");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 > sayi2)
            //{
            //    if (sayi1 > sayi3)
            //    {
            //        Console.WriteLine(sayi1);
            //    }
            //}
            //if (sayi2 > sayi1)
            //{
            //    if(sayi2 > sayi3)
            //    {
            //        Console.WriteLine(sayi2);
            //    }   
            //} 
            //if(sayi3 > sayi1)
            //{
            //    if (sayi3 > sayi2)
            //    {
            //        Console.WriteLine(sayi3);
            //    }
            //} 
            //Console.Write("1. sayıyı gır: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı gır: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3. sayıyı gır: ");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //if(sayi1>=sayi2 && sayi1 >= sayi3)
            //{
            //    Console.WriteLine(sayi1);
            //}
            //else if ( sayi2>=sayi1 && sayi2 >= sayi3)
            //{
            //    Console.WriteLine(sayi2);

            //}
            //else if (sayi3 >= sayi1 && sayi3 >= sayi2)
            //{
            //    Console.WriteLine(sayi3);

            //}


            //Console.Write("1. sayıyı gır: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2. sayıyı gır: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int buyukSayi=0;
            //if (sayi1 > sayi2)
            //{
            //    buyukSayi = sayi1;
            //} 
            //else if(sayi1 < sayi2)
            //{
            //    buyukSayi = sayi2;
            //}
            //Console.WriteLine(buyukSayi);
            //int buyukSayı=sayi1>sayi2 ? sayi1 : sayi2;

            //Console.WriteLine(buyukSayı);





            Console.Write("1. sayıyı gır: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı gır: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string sonuc = sayi1 > sayi2 ? "1. sayı 2. sayıdan buyuktur." :
                              sayi2 > sayi1 ? "2. sayı 1. sayıdan buyuktur" :
                                    "2 sayı bırbırıne esıttır";
            Console.WriteLine(sonuc);


        }
    }
}