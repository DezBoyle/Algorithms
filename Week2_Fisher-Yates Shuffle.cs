using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Week2_Fisher_Yates_Shuffle
    {
        static int temp, rand;
        static Random random;

        //For each element of the array, pick a random index and swap
        public static void Shuffle(ref int[] arry)
        {
            if(random == null)
            { random = new Random(); }

            for(int i = 0; i < arry.Length; i++)
            {
                rand = random.Next(0, arry.Length);
                Swap(ref arry, i, rand);
            }
        }

        static void Swap(ref int[] arry, int x, int y)
        {
            int temp = arry[y];
            arry[y] = arry[x];
            arry[x] = temp;
        }
    }
}
