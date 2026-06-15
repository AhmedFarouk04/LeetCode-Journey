using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Week_10DynamicPrograming
{
    public class Coin_Change
    {
        public class Solution
        {
            public int CoinChange(int[] coins, int amount)
            {
                int[] dp = new int[amount + 1];

                Array.Fill(dp, amount + 1);

                dp[0] = 0;

                for (int a = 1; a <= amount; a++)
                {
                    foreach (int coin in coins)
                    {
                        if (a - coin >= 0)
                        {
                            dp[a] = Math.Min(dp[a], dp[a - coin] + 1);
                        }
                    }
                }

                return dp[amount] == amount + 1 ? -1 : dp[amount];
            }
        }
    }
}
