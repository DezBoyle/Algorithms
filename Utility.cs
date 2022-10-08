using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal static class Utility
    {
        static string output = "";

        public static void PrintHeader(string text)
        {
            string spacer = new string(new char[text.Length + 8]);
            Print(spacer);
            Print("    " + text, ConsoleColor.Green);
            Print(spacer);
        }

        public static void Print(string text) { Print(text, ConsoleColor.Yellow); }
        public static void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("  " + text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SetIncreasingValues(this int[] arry)
        {
            for(int i = 0; i < arry.Length; i++)
            {
                arry[i] = i;
            }
        }

        public static void PrintArray(this int[] arry)
        {
            output = "";

            foreach(int i in arry)
            {
                output += i.ToString() + " ";
            }

            Print(output, ConsoleColor.White);
        }
        public static void PrintArray(this string[] arry)
        {
            output = "";

            foreach (string i in arry)
            {
                output += i + " ";
            }

            Print(output, ConsoleColor.White);
        }
    }
}