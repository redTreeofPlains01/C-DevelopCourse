using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void displayFrequencyOfeachElement(int[] array)
        {
            //create a dictionary list
            Dictionary<int, int> Freq = new Dictionary<int, int>();

            //go thru the array list
            for (int i = 0; i < array.Length; i++)
            {//check if array value is a key of the Freq-dictionary

                //if No make a new key pair in the Freq-dictionary, with value 1
                //!!-Error: 
                /*if (array[i] != Freq[array[i]])
                {
                    Freq[i] = 1;
                }
                //if yes increase the value
                else if (array[i] == Freq[i])
                {
                    Freq[i]++;
                }*/

                //if yes increase the value
                if (Freq.ContainsKey(array[i]))
                {
                    Freq[array[i]]++;
                }
                else
                {
                    Freq[array[i]] = 1;
                }

                //else add keyvalue pair
            }
            //return the freq-Dictionary
            //print directly instread and make method void
            //return Freq;
            foreach (KeyValuePair<int, int> kvp in Freq)
            {
                Console.WriteLine(kvp.Key + "->" + kvp.Value);
            }
        }

        static void Main(string[] args) {

            //make an array
            //int[] elements = new int[] { 4, 7, 7, 5, 6, 8, 8, 8, 3, 2, 1 };
            
            //Dictionary<int,int> displayList = new Dictionary<int, int>();

            //call the displayFrequencyOfeachElement method
            //displayList= displayFrequencyOfeachElement(elements);


            //Combnine above : as a challemnge call the method with an array
            /*displayList= displayFrequencyOfeachElement(new int[] { 4, 7, 7, 5, 6, 8, 8, 8, 3, 2, 1 });*/
            displayFrequencyOfeachElement(new int[] { 4, 7, 7, 5, 6, 8, 8, 8, 3, 2, 1 });

            //Print the result to console using a foreach(kvp)loop
            /*foreach (KeyValuePair<int, int> kvp in displayList)
            {
                Console.WriteLine(kvp.Key + "->" + kvp.Value);
            }*/

        }
    }
}