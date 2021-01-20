using System;

namespace HackerRankProblems.Solutions
{
    public class FindDigits
    {
        public static int Resolve(int n) 
        {
            if (n == 0) return 0;

            var numbers = n.ToString();
            var total = 0;

            foreach (var num in numbers) 
            {
                var curNum = Convert.ToInt32(num.ToString());
                if (curNum == 0) continue;
                if (n % curNum == 0) total++;
            }

            return total;
        }
    }
} 