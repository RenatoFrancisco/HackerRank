using System;

namespace HackerRankProblems.Solutions
{
    public class ViralAdvertising 
    {
        public static int Resolve(int n)
        {
            var people = 5.0;
            var total = 0;

            for (var i = 0; i < n; i++)
            {
                var likes = (int)Math.Floor(people / 2.0);
                people = likes * 3;
                total += likes;
            } 

            return total;
        }
    }
}