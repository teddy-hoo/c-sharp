using System;
using System.Collections.Generic;

namespace c_sharp {
  public class CoinChange {

    public int DynamicChange (int[] coins, int amount) {
      int[] dp = new int[amount + 1];
      for (int i = 1; i < amount + 1; i++) {
        dp[i] = amount + 1;
      }
      dp[0] = 0;
      for (int i = 1; i <= amount; ++i) {
        for (int j = 0; j < coins.Length; ++j) {
          if (coins[j] <= i) {
            dp[i] = dp[i] > dp[i - coins[j]] + 1 ? dp[i - coins[j]] + 1 : dp[i];
          }
        }
      }
      return (dp[amount] > amount) ? -1 : dp[amount];
    }
    public Dictionary<string, int> cache;

    public int Change (int[] coins, int amount) {
      cache = new Dictionary<string, int> ();
      return recursiveChange (coins, coins.Length - 1, amount);
    }

    public int recursiveChange (int[] coins, int current, int amount) {
      if (cache.ContainsKey ("" + current + "_" + amount)) {
        return cache["" + current + "_" + amount];
      }
      if (amount == 0) {
        return 0;
      }
      if (current < 0) {
        return -1;
      }
      int number = amount / coins[current];
      int left = amount % coins[current];
      int final = Int32.MaxValue;
      while (number >= 0) {
        int next = recursiveChange (coins, current - 1, left);
        if (next != -1) {
          int s = next + number;
          if (final > s) {
            final = s;
          }
        }
        number--;
        left += coins[current];
      }
      cache["" + current + "_" + amount] = final == Int32.MaxValue ? -1 : final;
      return final == Int32.MaxValue ? -1 : final;
    }
  }
}