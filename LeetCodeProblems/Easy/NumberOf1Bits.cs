using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class NumberOf1Bits
    {
        public int HammingWeight(int n)
        {
            int setBits = 0;
            while (n > 0)
            {
                setBits += Convert.ToInt32((n & 1));
                n >>= 1;
            }
            return setBits;
        }
    }
}
