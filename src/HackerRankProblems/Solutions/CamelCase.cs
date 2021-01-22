using System.Linq;

namespace HackerRankProblems.Solutions 
{
    public class CamelCase
    {
        public static int Resolve(string s) => s.Count(x => char.IsUpper(x)) + 1;
    }
}