using System;

namespace Algorithms
{
    class Week1
    {
        // O(1)
        public static void PrintFirstElement(string[] arry, int k)
        {
            Console.WriteLine(arry[k]);
        }

        // O(n)
        public static void PrintAllElements(string[] arry)
        {
            foreach(string s in arry)
            {
                Console.Write("{s}, ");
            }
            Console.WriteLine("");
        }

        // O(n^2)
        public static void PrintAllElementPairs(string[] arry)
        {
            foreach(string a in arry)
            {
                foreach(string b in arry)
                {
                    Console.Write($"[{a}, {b}], ");
                }
            }
            Console.WriteLine("");
        }
    }
}