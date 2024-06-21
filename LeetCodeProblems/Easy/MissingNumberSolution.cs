using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;       

namespace LeetCodeProblems.Easy
{
    public class MissingNumberSolution
    {
        public int MissingNumber(int[] nums)
        {
            // Step 1: Sort the array
            Array.Sort(nums);

            // Step 2: Find the first position where the index does not match the value
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }

            // If all indices match, then the missing number is n
            return nums.Length;
        }
    }
}
