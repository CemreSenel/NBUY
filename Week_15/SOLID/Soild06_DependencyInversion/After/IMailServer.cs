using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Soild06_DependencyInversion.After
{
    public interface IMailServer
    {
        void Send(string to, string body);   
    }
}
