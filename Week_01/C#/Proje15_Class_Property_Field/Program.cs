namespace Proje15_Class_Property_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrencı1 = new Ogrenci();
            ogrencı1.OgrNo = 11;
            ogrencı1.Ad = "ahmet";
            ogrencı1.Sinif = "9A";


            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrNo = 20;
            ogrenci2.Ad = "cemre";
            ogrenci2.Sinif = "10B";


            int[] sayilar = { 32, 54, 33 };
            Ogrenci ogrenci3 = new Ogrenci()
            {
                OgrNo = 15,
                Ad = "umay",
                Sinif = "10C"
            };


            Ogrenci[] ogrenciler = { ogrencı1, ogrenci2, ogrenci3 };
            //for (int i = 0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine($"{ogrenciler[i].Ad},sinif: {ogrenciler[i].Sinif}");
            //}
            //foreach (var siradakiOgrenci in ogrenciler)
            //{
            //    Console.WriteLine(siradakiOgrenci.Ad + ", "+ siradakiOgrenci.OgrNo + ", "+ siradakiOgrenci.Sinif);
            //}

            //foreach (var siradakiSayi in sayilar)
            //{
            //    Console.WriteLine(siradakiSayi*siradakiSayi);
            //}


        }
        class Ogrenci
        {
            private int ogrNo;

            public int OgrNo
            {
                get { return ogrNo; }
                set { ogrNo = value; }
            } public string Sinif { get; set; }

        }
    }
}