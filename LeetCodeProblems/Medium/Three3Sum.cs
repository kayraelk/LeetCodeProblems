using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    internal class Three3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums); // Step 1: Sort the array
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue; // Skip duplicate elements
                }

                int left = i + 1, right = nums.Length - 1;

                while (left < right)
                {
                    int total = nums[i] + nums[left] + nums[right];

                    if (total == 0) // If we find a triplet
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++; // Skip duplicates
                        while (left < right && nums[right] == nums[right - 1]) right--; // Skip duplicates
                        left++;
                        right--;
                    }
                    else if (total < 0)
                    {
                        left++; // Move left pointer to the right to increase the sum
                    }
                    else
                    {
                        right--; // Move right pointer to the left to decrease the sum
                    }
                }
            }

            return result;
        }
        internal static void PrintResult(IList<IList<int>> result)
        {
            foreach (var triplet in result)
            {
                Console.WriteLine("[" + string.Join(", ", triplet) + "]");
            }
            if (result.Count == 0)
            {
                Console.WriteLine("[]");
            }
            Console.WriteLine();
        }

    }
}
