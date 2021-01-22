using System;
using System.Linq;

namespace HackerRankProblems.Solutions
{
    public class LonelyInteger
    {
        public static int Resolve(int[] a)
        {
            var unique = 0;
            foreach (var n in a)
                if (a.Count(x => x == n) == 1) unique = n;  

            return unique;
        }
    }
}