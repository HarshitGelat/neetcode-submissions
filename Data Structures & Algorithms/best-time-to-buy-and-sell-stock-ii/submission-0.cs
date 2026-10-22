public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int i=0;
        while(i<prices.Length - 1) {
            while (i < prices.Length - 1 && prices[i] >= prices[i + 1]) {
                i++;
            }
            int buy = prices[i];

            while (i < prices.Length - 1 && prices[i] <= prices[i + 1]) {
                i++;
            }

            int sell = prices[i];
            profit += sell - buy;
        }

        return profit;
    }
}