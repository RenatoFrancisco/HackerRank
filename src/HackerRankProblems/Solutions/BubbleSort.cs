using System;
using System.Collections.Generic;

namespace HackerRankProblems.Solutions;

public class BubbleSort
{
    public static void Resolve(List<int> a)
    {
        var ultimoIndice = a.Count - 1;
        var trocas = 0;

        for (var i = 0; i < ultimoIndice; i++)
        {
            for (var j = 0; j < ultimoIndice; j++)
            {
                var atual = a[j];
                var proximo = a[j + 1];
                if (atual > proximo) 
                {
                    a[j + 1] = atual;
                    a[j] = proximo;
                    trocas++;
                }
            }
        }

        Console.WriteLine($"Array is sorted in {trocas} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[ultimoIndice]}");
    }
}