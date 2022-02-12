using System;
using System.Collections.Generic;
using HackerRankProblems.Solutions;

namespace HackerRankProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = JumpingClouds.Resolve(new List<int> { 0, 0, 1, 0, 0, 1, 0});
            Console.Write(result);
        }
    }
}
