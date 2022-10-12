namespace Proje12_OOP_Work_01_Cozum
{
    interface IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    class Bolum : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
    }
    class Ogrenci : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
    internal class Program
    {
        static string GirisYap(string baslik)
        {
            Console.Write(baslik);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Bolum> bolumler = new List<Bolum>();

            for (int i = 0; i < 2; i++)
            {
                Bolum bolum = new Bolum();
                Console.Write($"{i + 1}.Bolum Id: ");
                bolum.Id = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}.Bolum Adı: ");
                bolum.Ad = Console.ReadLine();
                Console.Write($"{i + 1}.Bolum Acıklaması: ");
                bolum.Aciklama = Console.ReadLine();
                bolumler.Add(bolum);
                List<Ogrenci>ogrenciler = new List<Ogrenci>();  
                for (int j = 0; j < 3; j++)
                {
                    Ogrenci ogrenci = new Ogrenci();
                    Console.WriteLine($"{j + 1}.Ogrenci Id: ");
                    ogrenci.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{j + 1}.Ogrenci no: ");
                    ogrenci.OgrNo = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{j + 1}.Ogrenci ad: ");
                    ogrenci.Ad = (Console.ReadLine());
                    Console.WriteLine($"{j + 1}.Ogrenci soyad: ");
                    ogrenci.Soyad = (Console.ReadLine());
                    Console.WriteLine($"{j + 1}.Ogrenci yas: ");
                    ogrenci.Yas = int.Parse(Console.ReadLine());
                    bolum.Ogrenciler.Add(ogrenci);

                }
                bolum.Ogrenciler = ogrenciler;
                bolumler.Add(bolum);
            }
            foreach (var bolum in bolumler)
            {
                Console.WriteLine($"bolum ıd: {bolum.Id}-bolum adı: {bolum.Ad}-bolum acıklaması: {bolum.Aciklama}");
                foreach (var ogrenci in bolum.Ogrenciler)
                {
                    Console.WriteLine($"ogrenci ıd: {ogrenci.Id}-ogrencı adı: {ogrenci.Ad}-ogrenci soyadı: {ogrenci.Soyad}-ogrencı yası: {ogrenci.Yas}-ogrencı ogrno: {ogrenci.OgrNo}");
                }
            }
            Console.ReadLine();

        }

    }
}