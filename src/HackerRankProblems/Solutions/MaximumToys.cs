using System.Collections.Generic;

namespace HackerRankProblems.Solutions;

public class MaximumToys
{
    public static int Resolve(List<int> prices, int k)
    {
        var maximoBrinquedos = 0;
        var soma = 0;

        prices.Sort();

        foreach (var price in prices)
        {
            if (soma <= k)
            {
                soma += price;
                maximoBrinquedos++;
            }
        }

        return maximoBrinquedos -1;
    }
}