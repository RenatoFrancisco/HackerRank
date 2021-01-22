using System;
using HackerRankProblems.Solutions;

namespace HackerRankProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = LonelyInteger.Resolve(new int[] { 0, 2, 1, 2, 1 });
            Console.WriteLine($"Result: {result}");
        }
    }
}
