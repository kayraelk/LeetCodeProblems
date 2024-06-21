using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class ReverseBitsSolution
    {
        //Using bitwise
        public uint reverseBits(uint n)
        {
            uint reversed = 0;
            for (int i = 0; i < 32; i++)
            {
                // Extract the rightmost bit of n
                uint bit = n & 1;
                // Shift reversed left to make space for the new bit
                reversed = (reversed << 1) | bit;
                // Shift n right to process the next bit
                n >>= 1;
            }
            return reversed;
        }
        //Using arithmetic 

        //public uint reverseBits(uint n)
        //{
        //    uint reversed = 0;
        //    for (int i = 0; i < 32; i++)
        //    {
        //        // Extract the rightmost bit using modulo 2
        //        uint bit = n % 2;
        //        // Shift reversed left by multiplying by 2 and add the extracted bit
        //        reversed = reversed * 2 + bit;
        //        // Shift n right using integer division
        //        n /= 2;
        //    }
        //    return reversed;
        //}



    }
}
