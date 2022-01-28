using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateStrings
{
    //1. Use Linq: v.All(char.IsLower)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsUpperCase("hello").ToString());
            Console.WriteLine(IsLowerCase("hello").ToString());
            Console.ReadLine(); 
        }

        private static bool IsLowerCase(string v)
        {
            return v.All(char.IsLower);
        }

        private static bool IsUpperCase(string s)
        {
            return s.All(char.IsUpper); 
        }

    }
}
