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

            Utility.PrintHeader("Week2 - Fisher-Yates Shuffle");
            int[] arry2 = new int[100];
            arry2.SetIncreasingValues();
            Utility.Print("Before");
            arry2.PrintArray();
            Week2_Fisher_Yates_Shuffle.Shuffle(ref arry2);
            Utility.Print("After");
            arry2.PrintArray();

            Utility.PrintHeader("Week3 - DataStructures");
            Week3_DataStructures.DictionaryExample();
            Week3_DataStructures.QueueExample();

            Utility.PrintHeader("Week4 - SortingAlgorithms");
            Week4_SortingAlgorithms.BubbleSort(ref arry2);
            arry2.PrintArray();
            Week2_Fisher_Yates_Shuffle.Shuffle(ref arry2);
            Week4_SortingAlgorithms.InsertionSort(ref arry2);
            arry2.PrintArray();
            Week2_Fisher_Yates_Shuffle.Shuffle(ref arry2);
            Week4_SortingAlgorithms.SelectionSort(ref arry2);
            arry2.PrintArray();

            Console.WriteLine("Busted");
            Utility.PrintHeader("Week5 - Searching");

            Utility.Print("BinarySearch: Searching for value: 44");
            Utility.Print("Found at index: " + Week5_Searching.BinarySearch(arry2, 44));
            Utility.Print("Linear Search: Searching for value: 82");
            Utility.Print("Found at index: " + Week5_Searching.LinearSearch(arry2, 82));
            Utility.Print("Linear Search: Searching for value: 55");
            Utility.Print("Found at index: " + Week5_Searching.InterpolationSearch(arry2, 55));



            Console.ReadKey(); //END
        }
    }
}