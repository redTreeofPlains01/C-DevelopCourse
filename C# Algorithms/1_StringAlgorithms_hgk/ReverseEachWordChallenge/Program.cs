using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text;

namespace ReverseEachWordChallenge
{
    class Program
    {
        //In this challenge, you'll create an algorithm that reverses each word in a sentence. The input to the function will be a string and the output will be a new string where each word is reversed. There will be no punctuation and each word will be separated by spaces. Casing should remain the same. If a given letter was uppercase, it should remain uppercase in the reversal.

        /*static String ReverseEachWord(String input)
        {
            String result = Regex.Replace(input, @"\p{P}", "").Trim(); 
            //input.Trim().Replace(",", "");
            string arr = Reverse(result);
            return arr;
        }*/


        static String ReverseEachWord(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            StringBuilder result = new StringBuilder();
            String[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse(arr[i]));
                if(i != arr.Length - 1)
                {
                    result.Append(" ");    
                }
            }
            return result.ToString();
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
