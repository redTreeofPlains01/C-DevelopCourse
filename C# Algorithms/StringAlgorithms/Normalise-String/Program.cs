using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normalise_String
{
    internal class Program
    {
        static string NormalizeString(String input)
        {
            //string lowercased = input.ToLower();    
            //string trimmed = lowercased.Trim(); 
            //Trim-trims space/s at the ends only 
 
            return input.ToLower().Trim().Replace(",", "");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NormalizeString(" Hello There, BUDDY      "));
            Console.ReadLine();
        }
    }
}
