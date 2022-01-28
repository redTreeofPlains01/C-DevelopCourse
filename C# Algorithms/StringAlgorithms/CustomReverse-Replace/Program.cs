using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  //for stringbuilder
using System.Threading.Tasks;

namespace CustomReverse_Replace
{
    internal class Program
    {

        static string Reverse(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }
            //!! using string uses many unecessary data becos string is immutable. tf use: stringbuilder-
            //!! Stringbuilder works differently to string in memory- expands dynamically and does not create new mwmory
            //string creats new memory each time string is modified.
            //is more efficient than just string
            StringBuilder reversed= new StringBuilder(input.Length);
            //here we want to go reverse from the end and decrement i

            //go thru the string backwards and then append to new variable- start at last index, decrement until zero
            // !! start at last index ; decrement until zero ; decrement
            for (int i = input.Length -1 ; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed.ToString();
        }

        //Making use of Array which has a reverse method
        static string Reverse2(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                return input;
            }

            //This approach makes use of  Array which has bulit in reverse function
            
            //create a char array by converrting the string using ToCharArray
            char[] arr = input.ToCharArray();

            ///uyse the Reverse fx:  !! this does not create a new array it just  modifies the array- 
            Array.Reverse(arr);

            //convert to back to string  and return
            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Hello World"));
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse(null));

            Console.WriteLine(Reverse2("Hello World"));
            Console.WriteLine(Reverse2(""));
            Console.WriteLine(Reverse2(null));

            Console.ReadLine();
        }
    }
}
