using System;

namespace HackerRankProblems.Solutions
{
    public class BeatifulDaysAtTheMovies 
    {
        public static int Resolve(int i, int j, int k) 
        {
            var counter = 0;
            for (var num = i; num <= j; num++)
            {
                var reverseNum = ReverseNumber(num);
                var diff = Math.Abs(num - reverseNum);
                counter += diff % k == 0 ? 1 : 0;
            }

            return counter;
        }

        private static int ReverseNumber(int number) 
        {
            var left = number;
            var reverseNumber = 0;
            while(Convert.ToBoolean(left))
            {
                var r = left % 10;   
                reverseNumber = reverseNumber * 10 + r;
                left = left / 10;
            }

            return reverseNumber;
        }
    }
}