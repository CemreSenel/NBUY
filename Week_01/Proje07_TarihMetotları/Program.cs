namespace Proje07_TarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Today);

            //DateTime dogumTarihi = new DateTime(1995, 3, 15);//15/03/1995
            //DateTime bugun = DateTime.Now;
            //TimeSpan span=bugun.Subtract(dogumTarihi);
            //Console.WriteLine($"Toplam {Math.Floor(span.TotalDays)} gundur yasıyorsunuz");

            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun.ToLongDateString());// 5 ekım 200 Carsamba
            //Console.WriteLine(bugun.ToLongTimeString());// 13:35:30
            //Console.WriteLine(bugun.ToShortDateString());//5.10.2022
            //Console.WriteLine(bugun.ToShortTimeString());//13:35

            //Bir sonrakı yılım ılk gununun tarıhını bulalım

            //DateTime bugun = DateTime.Now;
            //int yıl = bugun.Year + 1;
            //DateTime sonuc = new DateTime(yıl, 1, 1);
            //Console.WriteLine(sonuc.ToLongDateString());

            //bir sonrakı ayın ılk gununun tarıhı
            //DateTime bugun = DateTime.Now;
            //int yıl = bugun.Year;
            //int ay = bugun.Month + 1;
            //DateTime sonuc = new DateTime(yıl, ay, 1);
            //Console.WriteLine(sonuc);


            DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugün + 1)
            
            //ertesi günün tarihini bulup ekrana yazdıran programı yazınız.
        }
    }
}