using System;

namespace HackerRankProblems.Solutions
{
    public class AlternatingCharacters
    {
        public static int Resolve(string s) 
        {
            var deletions = 0;
            for (int i = 0; i < s.Length - 1; i++)
                if (string.Equals(s[i], s[i + 1])) deletions++;

            return deletions;
        }
    }
}