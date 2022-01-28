using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void ParseContents(string s)
        {
            Console.WriteLine("Option 1 ");
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Option 2 ");
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }
            //Which is better? depends on criteria 
        }
        //Q: is item at even indexes?
        static Boolean IsAtEvenIndex(String s, char item)
        {
            if(String.IsNullOrEmpty(s))
            {
                return false; 
            }  
            for (int i = 0; i < s.Length/2 + 1; i=i+2)  //Check for small number how many iterations needed: if string = hello we need to check 0, 2, 4 ==  or 3 iterations == 5/2 +1 == i < 5/2+1
            {
                if (s[i] == item ){
                    return true;    
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World".ToLower().Contains("ll"));
            //ParseContents("HELLO WORLD");
            
            string input = "HeLLo";
            Console.WriteLine(IsAtEvenIndex(input, 'L'));
            Console.WriteLine(IsAtEvenIndex(input, 'h'));
            Console.WriteLine(IsAtEvenIndex(input, '0'));
            Console.WriteLine(IsAtEvenIndex(input, 'e'));
            Console.WriteLine(IsAtEvenIndex(input, 'l'));
            Console.ReadLine();
        }
    }
}
