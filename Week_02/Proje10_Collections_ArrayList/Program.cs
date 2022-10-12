using System.Collections;

namespace Proje10_Collections_ArrayList
{
    internal class Program
    {
        static void Yazdir(ArrayList arraylist)
        {
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {

            ArrayList sayilar = new ArrayList() { 54, 12, 66, 34, 19 };
            Console.WriteLine("default sıra");
            Yazdir(sayilar);
            sayilar.Sort();
            Console.WriteLine("*********");
            Console.WriteLine("kucukten buyuge");
            Yazdir(sayilar);
            sayilar.Sort();
            Console.WriteLine("*********");
            Console.WriteLine("buyukten kucuge");
            sayilar.Reverse();
            Yazdir(sayilar);







            //ArrayList myList = new ArrayList();

            //myList.Add(120);
            //myList.Add("120");
            //myList.Add("zeynep");
            //myList.Add(11.5);
            //myList.Add(DateTime.Now);
            //myList.Add(true);


            //myList.Insert(0, "yenı eleman");

            //ArrayList addedList = new ArrayList() { "aysen umay", "fercan sercan", "kazım kolkanat" };
            //myList.InsertRange(4, addedList);
            //myList.AddRange(addedList);

            ////myList.Remove("120");
            ////myList.RemoveAt(0);
            ////myList.RemoveRange(0, 10);


            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);

            //}
            //if (myList.Contains("zeynep")==true)
            //{
            //    Console.WriteLine("zeynep lıstede mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("zeynep e haber ver");
            //}

            //Console.WriteLine();
            //Console.WriteLine(myList[3]);

            Console.ReadLine();

        }
    }
}