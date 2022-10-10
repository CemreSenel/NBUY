using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje02_Methods
{
    public class MethodOverload
    {
        public void DenemeMetodu()
        {
            Console.WriteLine(Program.Topla(3, 5));
        }
        
        // gonderılen 3 sayı arsında ıstersem toplam ısterse carpma yapsın
        public int Islem(bool islemTuru,int s1, int s2, int s3=0)
        {
            if (islemTuru==true)
            {
                return s1 + s2 + s3;

            }
            else
            {
                if (s3 == 0) s3 = 1;
                return s1 * s2 * s3;

            }
        }
        public int Topla(bool islemTuru,int s1, int s2, int s3=0)
        {
            if (islemTuru==true)
            {
                return s1 + s2 + s3;

            }
            else
            {
                if (s3 == 0) s3 = 1;
                return s1 * s2 * s3;

            }
        }

        public int Topla(int[] sayilar)
        {
            int sonuc = sayilar.Sum();
            return sonuc;
        }


    }


}
