using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Week5_Searching
    {
        public static int LinearSearch(int[] arry, int search)
        {
            for(int i = 0; i < arry.Length; i++)
            {
                if(arry[i] != search)
                { continue; }

                return i;
            }
            return -1;
        }

        public static int BinarySearch(int[] sortedArry, int search)
        {
            int left = 0;
            int right = sortedArry.Length - 1;

            while(left <= right)
            {
                int middle = (int)MathF.Floor((sortedArry[right] + sortedArry[left]) / 2);
                if (sortedArry[middle] != search)
                {
                    if(sortedArry[middle] > search)
                    {
                        //go left
                        right = middle - 1;
                    }
                    else if(sortedArry[middle] < search)
                    {
                        //go right
                        left = middle + 1;
                    }
                    else
                    {
                        return middle;
                    }
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }

        public static int InterpolationSearch(int[] sortedArry, int search)
        {
            int left = 0;
            int right = sortedArry.Length - 1;

            while (left <= right)
            {
                int probe = left + (right - left) * (search - sortedArry[left]) / (sortedArry[right] - sortedArry[left]);
                if (sortedArry[probe] != search)
                {
                    if (sortedArry[probe] > search)
                    {
                        //go left
                        right = probe - 1;
                    }
                    else if (sortedArry[probe] < search)
                    {
                        //go right
                        left = probe + 1;
                    }
                    else
                    {
                        return probe;
                    }
                }
                else
                {
                    return probe;
                }
            }

            return -1;
        }


    }
}
