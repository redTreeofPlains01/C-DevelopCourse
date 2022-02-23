using System;

namespace Algorithms {
    class Program {

        //int? this is for the null exceptions
        static int? LinearSearch(int[] input, int n) {

            foreach (var item in input)
            {
                if (item == n)
                {
                    return n;
                }
            }
            
            return null;
        }

        static void Main(string[] args) {
            int[] arr = {1, 2, 3, 4, 5, 6 };
            LinearSearch(arr, 4);

            Console.WriteLine(LinearSearch(arr, 6));
            Console.WriteLine(LinearSearch(arr, 8));
            Console.ReadLine();
        }
    }
}