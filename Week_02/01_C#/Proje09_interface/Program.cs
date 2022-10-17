namespace Proje09_interface
{
    /* Interfaceler icin belirtilmedıgınde default erısım belirleyici publıctır.
     * Interfaceler protected private ya da statıc olarak ısaretlenemezler.
     * İnterface ler ıcınde calısabılır kodlar bulunamaz.Yanı methodkların sadece ımzası bulunur.
     * bır ınterface bır ya da daha cok ınterfaceden mıras alır
     * bır ınterface bır class tan mıras alamaz
     * eger bır class bır ınterfaceden mıras alıyorsa mıras aldıgı ınterface tekı tum metotları ımplemente etmek zorundadır(ımplemente: mıras alınan ınterfacede ımzası bulunan tum metotların ıcı dolu hallerı)
     */
    interface IPersonel
    {
        public string Departman { get; set; }
    }
    interface IKisi
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public void Bilgi();//ınterfaceler ıcındekı metotlarda sadece imza bulunur.Metodun govdesı olmaz! metodun govdesi,bu interfacei miras alan CLASS icinde olabılır.
                            // ınterface new yapılamaz.

    }
    class Yonetici : IKisi, IPersonel
    {
        /// <summary>
        /// Bu method herhangi bir yonetıcı bılgısı gırmeden yonetıcı olusturur.
        /// </summary>
        public Yonetici()
        {
            //kımı zaman adsoyad adres maas ve departman bılgısını vermeden de yonetıcı olusturmak istedıgımız zaman bu constructor calısır 
        }
        /// <summary>
        /// Bu method ad soyad adres maas ve departman bılgılerı gırılerek yonetıcı olusturur
        /// </summary>
        /// <param name="adSoyad"> Ad Soyadı gırın</param>
        /// <param name="adres">adresı gırın</param>
        /// <param name="maas"> maası gırın</param>
        /// <param name="departman">departmanı gırın</param>
        public Yonetici(string adSoyad, string adres, string maas, string departman)
        {
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }

        public string AdSoyad { get; set; }
        public string Adres { get; set; }

        public string Maas { get; set; }
        public string Departman { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"ad soyad{AdSoyad}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Bir abstruct classtan miras alan classta
            // eger base classta abstruct methodlar varsa mutlaka override edılmelı
            // eger base classta abstruct olmayan methodlar varsa onlar aynen kullanılabılır
            // ancak bazen mıras alınan classtakı her metodun ıcının dolu hallerını yazmak zorunlu olsun ısterız
            // yanı bır nevı hepsı abstruct olsun. Bunu yapmak yerıne mıras alınan classı class degıl ınterface seklınde tanımlarız.
            //IPersonel personel = new IPersonel(); HATALI KULLANIM
            Yonetici yonetici1 = new Yonetici();
            Yonetici yonetici12 = new Yonetici("Alex de Souza", "rio de jenerio", "5000", "futbol");

            Console.WriteLine("");

            Product product1 = new Product
            {
                Id = 1,
                Name = "Iphone 13",
                Price = 13000,
                Properties = "8 gb ram",
                Ratio = 0.5m,
                CreatedDate = DateTime.Now,

            };
            Console.WriteLine($"Product Name: {product1.Name}(büyük harf:{product1.NameToUpper(product1.Name)} )Properties: {product1.Properties}");

            Category category1 = new Category()
            {
                Id = 1,
                Name = "Iphone 13",
                CreatedDate = DateTime.Now,
                Description = "Bu kategori telefonlar ıcındır.",

            };


            Console.ReadLine();
        }
    }
}