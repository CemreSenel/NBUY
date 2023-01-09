﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid03_OpenClosed.After
{
    public class Kare : Sekil
    {
        public Kare(int kenar)
        {
            Kenar = kenar;
        }

        public int Kenar { get; set; }
        public override double AlanHesapla()
        {
            return Math.Pow(Kenar, 2); 
        }
    }
}
