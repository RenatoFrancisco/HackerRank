using System;
using System.Collections.Generic;
using HackerRankProblems.Solutions;

namespace HackerRankProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = MaximumToys.Resolve(new List<int> { 52952808, 39586066, 70403274, 84627963, 46636834, 13906132, 18138605, 22451014, 71348257, 91939176, 17451226, 31356009, 15266983, 33392541, 37992362, 55743111, 55380991, 48022854, 54843595, 440 }, 100000);
            Console.WriteLine(result);
        }
    }
}
