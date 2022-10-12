using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje12_OOP_Work_01
{
     interface IPersonel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        


    }

    public class Bolum:IPersonel
    {

        public string Description { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; }
        



    }
    public class Ogrenci:IPersonel
    {

        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    

}
