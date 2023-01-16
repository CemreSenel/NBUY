using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Core
{
    public static class Jobs
    {
        public static string InitUrl(string url)
        {
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");
            url = url.ToLower();
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ş", "s");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            url = url.Replace(" ", "-");
            url = url.Replace(".", "");
            url = url.Replace("/", "");
            url = url.Replace("\"", "");
            url = url.Replace("'", "");
            url = url.Replace("(", "");
            url = url.Replace(")", "");
            url = url.Replace("[", "");
            url = url.Replace("]", "");
            url = url.Replace("{", "");
            url = url.Replace("}", "");
            return url;
        }
    }
}
