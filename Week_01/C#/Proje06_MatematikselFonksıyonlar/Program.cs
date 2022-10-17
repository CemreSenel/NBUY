namespace Proje06_MatematikselFonksıyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 43;
            //int sayi2 = 55;
            //int minimum = Math.Min(sayi1, sayi2);
            //int maximum = Math.Max(sayi1, sayi2);

            //Console.WriteLine($"Minimum sayı: {minimum\nMaximum sayı:{maximum}");

            //int taban = 4;
            //int us = 3;
            //double sonuc = Math.Pow(taban, us);
            //Console.WriteLine(sonuc);
            //Console.Write("Taban: ");
            //int taban = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Us: ");
            //int us = int.Parse(Console.ReadLine());
            //double sonuc = Math.Pow(taban, us);
            //Console.WriteLine($"Sonuc: {sonuc}");

            double sayi = 5.493486;
            Console.WriteLine(Math.Ceiling(sayi));
            Console.WriteLine(Math.Floor(sayi));
            Console.WriteLine(Math.Round(sayi,0));


        }
    }
}