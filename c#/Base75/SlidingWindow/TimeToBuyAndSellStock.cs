namespace Base75.SlidingWindow;

public class TimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        var buy = prices[0];
        var profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (buy > prices[i])
            {
                buy = prices[i];
            }
            profit = Math.Max(profit, prices[i] - buy);
        }

        return profit;
    }
}