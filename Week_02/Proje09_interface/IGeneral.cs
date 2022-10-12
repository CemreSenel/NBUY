using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje09_interface
{
    public interface IGeneral
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public string NameToUpper(string name);



    }
    public interface IGeneral2
    {
        public string NameToUpper();
    }
    public class Product 
    {
       
       
    }
    public class Category 
    {

    }
    
}
