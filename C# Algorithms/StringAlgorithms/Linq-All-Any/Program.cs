using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_All_Any
{
    internal class Program
    {
        static Boolean IsUppercase(string s)
        {
            return s.All(char.IsUpper);//  Linq method "input.all"
        }

        static Boolean IsLowercase(string s)
        {
            return s.All(char.IsLower);
        }

        static Boolean isPasswordComplex(string s)
        {//the "any method"
            return s.Any(char.IsUpper) && s.Any(char.IsLower)
                && s.Any(char.IsDigit);
        }

        static void Main(string[] args)
        {
            // Console.WriteLine(IsUppercase("hello"));
            // Console.WriteLine(IsUppercase("HELLO"));

            // Console.WriteLine(IsLowercase("hello"));
            // Console.WriteLine(IsLowercase("HELLO"));

            Console.WriteLine(isPasswordComplex("Hell0"));
            Console.WriteLine(isPasswordComplex("Hello"));
            Console.WriteLine(isPasswordComplex("HellO"));
            Console.WriteLine(isPasswordComplex("HeLlo"));
            Console.WriteLine(isPasswordComplex("hello"));
            Console.WriteLine(isPasswordComplex(" "));

            Console.ReadLine(); 
        }

    }
}

