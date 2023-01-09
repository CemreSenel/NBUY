using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid03_OpenClosed.After
{
    public class Daire : Sekil
    {
        public Daire(int yaricap)
        {
            Yaricap = yaricap;
        }

        public int Yaricap { get; set; }
        public override double AlanHesapla()
        {
            return Math.PI * Math.Pow(Yaricap, 2);
        }
    }
}
