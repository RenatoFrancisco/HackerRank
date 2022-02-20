using System.Collections.Generic;

namespace HackerRankProblems.Solutions
{
    public class JumpingClouds
    {
        public static int Resolve(List<int> c)
        {
            var jumps = 0;
            var i = 0;

            while (i < c.Count - 2) 
            {
                if (c[i + 2] == 0) i += 2;
                else i++;

                jumps++;
            }

            if (i < c.Count - 1) jumps++;

            return jumps;
        }
    }
}