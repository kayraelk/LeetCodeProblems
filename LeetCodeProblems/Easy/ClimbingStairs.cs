﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            int[] steps = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                if (i == 0) steps[i] = 1;
                else if (i == 1) steps[i] = 1;
                else
                {
                    steps[i] = steps[i - 1] + steps[i - 2];
                }
            }
            return steps[n];
        }
    }
}
