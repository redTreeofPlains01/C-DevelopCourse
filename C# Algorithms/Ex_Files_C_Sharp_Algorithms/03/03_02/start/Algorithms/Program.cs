using System;
using System.Collections.Generic;

namespace Algorithms {

    //Common Linked list operations in C#
    class Program {


        static void Main(string[] args) {
           LinkedList<string> linky = new LinkedList<string>();
            //AddFirst
            //AddLast
            linky.AddFirst("Sarah");
            linky.AddLast("Polly");
            linky.AddLast("Rebceca");
            linky.AddLast("Jess");
            linky.AddLast("Gene");


            Console.WriteLine(linky.Contains("Polly"));
            Console.WriteLine(linky.Count);

            linky.RemoveFirst();    

            foreach (string link in linky) {
                Console.Write(link + "->");
            }
        }
    }
}