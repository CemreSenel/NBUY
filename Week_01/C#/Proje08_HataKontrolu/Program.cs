namespace Proje08_HataKontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //buraya normalde calısmasını ıstedıgımız kodları yazyoruz
                //try blogunda herhangi bir hata var mı yok mu kontrol edılıyor
                //eger bir hata olusursa CATCH bloguna yonlendırılıyor
                Console.Write("1.Sayıyı giriniz: ");
                int sayi1=Convert.ToInt32(Console.ReadLine());

                Console.Write("2.Sayıyı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("0 a bolme hatası");
                //Console.WriteLine(ex.Message);
            }
            
            catch(OverflowException ex)
            {
                Console.WriteLine("haddınden fazla buyuk bır sayı gırdınız");
            }
            catch(Exception ex)
            {
                Console.WriteLine("bılınmeyen bır hata olustu.");
            }
            finally
            {
                //try ya da catch bloklarından hangisi calısırsa caıssın,
                //her halukarda calısmasını ıstedıgımız kodları buraa yazarız.
                Console.WriteLine("program sona ermıstır.");
            }

        }
    }
}