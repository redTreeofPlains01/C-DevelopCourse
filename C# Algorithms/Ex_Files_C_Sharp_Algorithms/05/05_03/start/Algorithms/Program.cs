using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        //make a empty missing list
        //copy the second list to a hash set. 
        //compare the fiorst list to the hash set
        //if ! in hashset add to missinglist
        private static List<int> FindMissingElements(List<int> firstList, List<int> secondList) {
            List<int> missingList = new List<int>();
            HashSet<int> second = new HashSet<int>();
            foreach (int i in secondList) {
                second.Add(i);
            }
            foreach (int i in firstList) {
                if (!second.Contains(i)) {
                    missingList.Add(i);
                }
                
            }
            return missingList;
        }


        static void Main(string[] args)
        {

            List<int> list1 = new List<int> { 1, 2, 3, 4 };
            List<int> list2 = new List<int> { 3, 4 };

            List<int> missingElements = FindMissingElements(list1, list2);

            foreach (int num in missingElements)
            {
                Console.WriteLine(num);

            }
        }
    }
}