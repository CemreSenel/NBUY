namespace Proje04_TipDönüstürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte a = 5;
            //short b = 10;
            //sbyte c = -30;
            //int d = a + b + c;//implıcıt convert-ortulu donusturme
            //Console.WriteLine($"sonuç(d)={d}");

            //string metin = "NBUY";
            //char karakter = 'k';
            //object e= metin + karakter + d;// ORTULÜ DONUSUM
            //Console.WriteLine($"Object={e}");

            //byte a = 155;
            //byte b = 101;
            ////byte c = Convert.ToByte(a + b);//explicit convert-bılınclı donusturme
            ////Console.WriteLine($"sonuc(c):{c}");

            //byte d = (byte)(a + b);//unboxing
            //Console.WriteLine($"sonuc(d):{d}");

            //int a = 511;
            //byte b = (byte)a;
            //Console.WriteLine(b);

            byte a = 155;
            byte b = 111;
            int c = a + b;
            Console.WriteLine(c);

            Convert.ToDouble(c);
            Convert.ToInt64(c);
            

        }
    }
}