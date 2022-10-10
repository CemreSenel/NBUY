namespace Proje03_SayiBulmaca_With_Methods
{
    internal class Program
    { 
      
        
        static void Main(string[] args)
        {
            // Sayı bulmaca oyununu yeni ögrendıgınız methods konusu baglamında yenıden hazırlayınız.
            // 5 tercıh hakkı olsun 
            // puan sıstemı olsun(1. tercıhınde bıldıyse 50,bılmedıkce 10 ar 10 ar dussun)
            // oyunu kaybettıgınde ya da kazandıgında YENIDEN OYNAMAK ISTIYOR İSE oynayabılsın
            string tercih;
            do
            {
                Console.Clear();
                Oyun.Oyna();
                do
                {
                    //Console.Clear();
                    Console.Write("Yeniden oynamak ister misiniz?[E/H]");
                    tercih = Console.ReadLine().ToUpper();
                } while (tercih != "H" && tercih != "E");
            } while (tercih != "H");
            Console.ReadLine();

        }
    }
}