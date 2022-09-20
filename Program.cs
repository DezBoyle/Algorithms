namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arry = new string[]
            {
                "Tree",
                "Vine",
                "Lilypad",
                "Moss",
                "Mushroom",
                "Flower"
            };

            Utility.PrintHeader("Week1 - Big O");
            Utility.Print("-Constant O(1)");
            Week1.PrintFirstElement(arry, 1); // O(1)
            Utility.Print("-Constant O(n)");
            Week1.PrintAllElements(arry); // O(n)
            Utility.Print("-Constant O(n^2)");
            Week1.PrintAllElementPairs(arry); // O(n^2)

            Console.ReadKey(); //END
        }
    }
}