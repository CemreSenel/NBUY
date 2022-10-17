namespace Proje02_Methods
{
    public class Program
    {
        //static void Topla(int sayi1,int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine();
        //    Console.WriteLine($"Toplam: {toplam}");
        //}
        //static void Cıkar(int sayi1, int sayi2)
        //{
        //    int fark = sayi1 - sayi2;
        //    Console.WriteLine();
        //    Console.WriteLine($"Fark: {fark}");
        //}
        public static int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;   
        }
        static int Cıkar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            return fark;
        }
        static int SiraNoBul(string metin,char karakter)
        {
            int sonuc = metin.IndexOf(karakter);
            return sonuc;
        }
        static bool VarMi(string metin, char karakter)
        {
            bool sonuc=metin.Contains(karakter);    
            return (sonuc); 
        }

        static void Main(string[] args)//METHOD
        {
            MethodOverload methodOverload = new MethodOverload();
            methodOverload.DenemeMetodu();

            //Console.Write("Birinci sayı: ");
            //int s1=int.Parse(Console.ReadLine());
            //Console.Write("ikinci sayı: ");
            //int s2 = int.Parse(Console.ReadLine());

            //int toplam=Topla(s1,s2);    
            //int fark=Cıkar(s1,s2);

            //Console.WriteLine($"Toplam: {toplam}, Fark: {fark}");
            //Console.WriteLine($"{toplam-fark}");

            //Kendısıne verılen metnın ıcınde aradıgınız karakterın kacıncı sırada oldugunu bulan metodu hazırlayınız.

            // Kendısıne verılen metnın ıcınde aradıgımız karakterın olup olmadıgını soyleyen bir metodu hazırlayınız.
            //Console.WriteLine(SiraNoBul("Wissen Akademie", 'A'));
            //Console.WriteLine(VarMi("Wissen Akademie", 'A') == true ? "İçinde geçiyor" : "İçinde geçmiyor");
            Console.WriteLine(methodOverload.Topla(25,42));
            Console.WriteLine(methodOverload.Islem(25, 42));


        }
    }
}