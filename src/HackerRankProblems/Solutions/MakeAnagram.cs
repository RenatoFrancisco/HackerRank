using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Solutions
{
    public class MakeAnagram
    {
        public static int Resolve(string a, string b)
        {
            var deletions = 0;
            var checkeds = new List<char>();
            foreach (var item in a) 
            {
                if (b.IndexOf(item) == -1) deletions++;
                else
                {
                    if (checkeds.Contains(item)) continue;
                    var diff = Math.Abs(a.Count(x => x == item) - b.Count(x => x == item));
                    deletions += diff;
                    checkeds.Add(item);
                }
            }

            foreach (var item in b) 
                if (a.IndexOf(item) == -1) deletions++;

            return deletions;
        }
    }
}