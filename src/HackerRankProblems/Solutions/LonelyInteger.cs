using System.Linq;

namespace HackerRankProblems.Solutions
{
    public class LonelyInteger
    {
        public static int Resolve(int[] a) => a.First(n => a.Count(x => x == n) == 1);
    }
}