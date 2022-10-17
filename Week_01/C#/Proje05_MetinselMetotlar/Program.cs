namespace Proje05_MetinselMetotlar;
class Program
{
    static void Main(string[] args)
    {
        // Bu projede metınsel ıslemlere dair bazı metotlar ogrenecegız
        //string metin = "Wissen Akademie";
        //int uzunluk = metin.Length;
        //Console.WriteLine($" {metin} metni {uzunluk} karakterdir");

        //string metin = "WİSSEN";
        //string kucukMetin = metin.ToLower();
        //Console.WriteLine(kucukMetin);
        //string buyukMetin = kucukMetin.ToUpper();
        //Console.WriteLine(buyukMetin);

        //string m1 = "wissen ";
        //string m2 = "wissen ";
        //int sonuc = String.Compare(m1, m2);
        //Console.WriteLine(m1);
        //Console.WriteLine(m2);
        //Console.WriteLine(sonuc);


        //Console.Write("1.metnı gırınız :");
        //string m1 = Console.ReadLine();
        //Console.Write("2. metnı gırınız :");
        //string m2 = Console.ReadLine();
        //int sonuc = String.Compare(m1, m2);
        //if(sonuc==0)
        //{
        //    Console.WriteLine("girilen iki metin birbirine EŞITTIR");
        //}
        //else
        //{
        //    Console.WriteLine("girilen ıkı metın bırbırınden farklıdır");
        //}

        //string m1 = "işkur";
        //string m2 = "egıtımleri";
        //string m3 = "wissen";
        ////string sonuc = m1 + m2;
        //string sonuc = String.Concat(m1,m2,m3);
        //Console.WriteLine(sonuc);

        //string ad = "cemre";
        //int yas = 27;
        //string okul = "BAU";
        // Benım adım Cemre.27 yasındayım.Okudugum okulun adı BAU
        //1)+ OPERATORU ILE
        //2)CONCAT ILE
        //3)$ İLE
        //1)
        //string sonuc1=("Benım adım " + ad + ". " yas + " yasındayım. Okudugum okulun adı"   + okul);
        //Console.WriteLine(sonuc1);
        //string sonuc3=$"benım adım{ad}.{yas} yasındayım"

        //string metin = "Merhaba.Bu hafta eğitime başladık.";
        //bool sonuc = metin.Contains(" ");
        //Console.WriteLine(sonuc);

        //string adres = "İstanbul Şehit ali mh. Can sk. No:6 Kadıköy/İstanbul";
        //bool sonuc = adres.EndsWith("İstanbul");
        //bool sonuc2 = adres.StartsWith("Selamı");
        //Console.WriteLine(sonuc + "," + sonuc2);
        // Adres içindekı c harfı kacıncı sıradadır


        //string aranacakifade = "Ş";

        //int siraNo = adres.ToLower().IndexOf(aranacakifade.ToLower());
        //Console.WriteLine($"C harfi {adres}içinde {siraNo}. sıradadır");


        //string aranacakifade = "Şehit ali";

        //int siraNo = adres.ToLower().IndexOf(aranacakifade.ToLower());
        //Console.WriteLine($" {aranacakifade}ifadesi {adres}içinde, {siraNo}. sıradadır");


        //string metin = "Wissen Akademie";
        //Console.WriteLine($"Metnin ilk hali: {metin}");
        //Console.WriteLine($"Akademi ifadesi silindikten sonraki hali: {metin.Remove(7)}");
        //Console.WriteLine($"Aka ifadesi silindikten sonraki hali: {metin.Remove(7,3)}");

        string urunAd = "IPhone 13 Pro";
        //iphone-13-pro
        //string sonuc = (urunAd.Replace(" ","-")).ToLower();
        string sonuc = urunAd.ToLower().Replace(" ", "-");
        Console.WriteLine(sonuc);
        string sonuc2 = urunAd.Replace("IPhone", "Samsung");
        Console.WriteLine(sonuc2);

    }
}
