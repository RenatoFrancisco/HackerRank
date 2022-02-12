using System;
using System.Collections.Generic;
using HackerRankProblems.Solutions;

namespace HackerRankProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = LeftRotation.Resolve(new List<int> { 1, 2, 3, 4, 5 }, 2);
            result.ForEach(x => Console.Write($"{x} "));
        }
    }
}
