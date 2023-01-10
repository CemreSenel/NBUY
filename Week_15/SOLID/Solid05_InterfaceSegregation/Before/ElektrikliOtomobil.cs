using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid05_InterfaceSegregation.Before
{
    public class ElektrikliOtomobil : IElektrikliOtomobil, IOtomobil
    {
        public string BataryaTipi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string BataryaTipiniGetir()
        {
            throw new NotImplementedException();
        }

        public decimal VoltajDegeriniGetir()
        {
            throw new NotImplementedException();
        }
    }
}
