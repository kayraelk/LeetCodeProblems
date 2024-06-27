using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class CoinChangeSolution
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] howMuchNumers = new int[amount + 1];
            howMuchNumers[0] = 0;
            for(int i = 1; i <= amount; i++)
            {
                howMuchNumers[i] = amount + 1;
            }

            for(int i = 0; i<= amount; i++)
            {
                foreach(int coin in coins)
                {
                    if(i -coin >= 0)
                    {
                        howMuchNumers[i] = Math.Min(howMuchNumers[i], 1 + howMuchNumers[i - coin]);
                    }
                }
            }

            return howMuchNumers[amount] == amount + 1 ? -1 : howMuchNumers[amount];
        }
    }
}
