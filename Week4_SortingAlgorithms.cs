using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Week4_SortingAlgorithms
    {
        public static void BubbleSort(ref int[] arry)
        {
            bool sorted = false;
            while(!sorted)
            {
                sorted = true;
                for(int i = 0; i < arry.Length - 1; i++)
                {
                    if (arry[i] > arry[i + 1])
                    {
                        int temp = arry[i + 1];
                        arry[i + 1] = arry[i];
                        arry[i] = temp;

                        sorted = false;
                    }
                }
            }
        }

        public static void InsertionSort(ref int[] arry)
        {
            for(int i = 0; i < arry.Length - 1; i++)
            {
                for(int x = i + 1; x > 0; x--)
                {
                    if (arry[x - 1] > arry[x])
                    {
                        int temp = arry[x - 1];
                        arry[x - 1] = arry[x];
                        arry[x] = temp;
                    }
                }
            }
        }
        
        public static void SelectionSort(ref int[] arry)
        {
            for(int i = 0; i < arry.Length - 1; i++)
            {
                int smallest = arry[i];
                int smallestIndex = i;
                for(int x = i; x < arry.Length; x++)
                {
                    if (arry[x] < smallest)
                    {
                        smallest = arry[x];
                        smallestIndex = x;
                    }
                }
                int temp = arry[smallestIndex];
                arry[smallestIndex] = arry[i];
                arry[i] = temp;
            }
        }
    }
}
