using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Linear_Search
{
    internal class Program
    {
        //int? this is for the null exceptions
        static int? LinearSearch(int[] input, int n)
        {

            foreach (var item in input)
            {
                if (item == n)
                {
                    return n;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            LinearSearch(arr, 4);

            /*Console.WriteLine(LinearSearch(arr, 6));
            Console.WriteLine(LinearSearch(arr, 8));*/
            //Console.ReadLine();


            // The most useful "inbuilt" functions to seach an array 
            // Lambda: given something => do something (Or often return something)


            int number =  Array.Find(arr, x => x == 1); //this finds the first occurrence ONLY
            Console.WriteLine(number);  

            int[] numbers= Array.FindAll(arr, x => x >= 3); //thsi finds all occurrences
            Array.ForEach(numbers, x => Console.WriteLine(x));
            //OR Array.ForEach(numbers,Console.WriteLine);
            Console.ReadLine();
        }
    }
}

