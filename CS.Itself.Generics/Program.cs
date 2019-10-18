using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Itself.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CustomTypeInfo<string>.GetTypeInfo());
            Console.WriteLine(CustomTypeInfo<DateTime>.GetTypeInfo());
            Console.WriteLine(CustomTypeInfo<Array>.GetTypeInfo());
        }
    }

    static class CustomTypeInfo <T>
    {
        public static string GetTypeInfo()
        {
            return typeof(T).ToString();
        }
    }
}
