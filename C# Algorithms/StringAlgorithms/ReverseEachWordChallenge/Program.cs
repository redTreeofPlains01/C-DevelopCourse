using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReverseEachWordChallenge
{
    class Program
    {

        static String ReverseEachWord(String input)
        {
            String result = Regex.Replace(input, @"\p{P}", "").Trim(); 
            //input.Trim().Replace(",", "");
            string arr = Reverse(result);
            return arr;
        }

        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Taylor, is a great worker..."));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam!"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));

            Console.ReadLine();
        }
    }
}
