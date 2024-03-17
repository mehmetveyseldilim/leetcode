// See https://aka.ms/new-console-template for more information

// Optimum O(N) Solution

int MaxProfit(int[] prices)
{
    int maxProfit = 0;
    int buy = prices[0];

    for (int i = 1; i < prices.Length; i++)
    {
        int profit = prices[i] - buy;

        if (profit > maxProfit)
            maxProfit = profit;

        if (buy > prices[i])
        {
            buy = prices[i];
        }
    }

    return maxProfit;
}

/*

O(N^2) Solution
int MaxProfit(int[] prices)
{
    int maxProfit = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        for (int j = i + 1; j < prices.Length; j++)
        {
            int profit = prices[j] - prices[i];

            if (profit > maxProfit)
                maxProfit = profit;
        }
    }

    return maxProfit;
}
*/


int[] ints = { 7, 6, 4, 3, 1 };

Console.WriteLine(MaxProfit(ints));
