using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Utility
    {
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
    }
}