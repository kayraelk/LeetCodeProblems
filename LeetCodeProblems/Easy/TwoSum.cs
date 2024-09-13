using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{

    public class TwoSum
    {
        public int[] TwoSumMethod(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var remain = target - nums[i];
                if (dic.ContainsKey(remain))
                {
                    return new int[] { dic[remain], i };
                }

                dic[nums[i]] = i;

            }

            return new int[0];

        }
    }

}
