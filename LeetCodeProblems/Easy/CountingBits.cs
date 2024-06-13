using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class CountingBits
    {
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                // result[i >> 1] is the number of 1's in i / 2
                // i & 1 is 1 if i is odd, 0 if i is even
                result[i] = result[i >> 1] + (i & 1);
            }
            return result;
        }
        //My solution
        //public int[] CountBits(int n)
        //{
        //    int[] result = new int[n + 1];
        //    for (int i = 0; i <= n; i++)
        //    {
        //        int iTemp = i;
        //        int count = 0;
        //        while (iTemp > 0)
        //        {
        //            count += Convert.ToInt32((iTemp & 1));
        //            iTemp >>= 1;
        //        }
        //        result[i] = count;
        //    }
        //    return result;
        //}

    }

}
