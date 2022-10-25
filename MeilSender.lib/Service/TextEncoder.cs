using System.Linq;

namespace MeilSender.lib.Service
{
    public static class TextEncoder
    {
        public static string Encode(string str,int key=1)
        {
            return new string(str.Select(c =>(char)(c+key)).ToString());
        }
        public static string Decode(string str, int key = 1) => Encode(str, -key);
    }
}
