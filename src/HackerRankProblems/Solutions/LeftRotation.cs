using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRankProblems.Solutions
{
    public class LeftRotation
    {
        public static List<int> Resolve(List<int> a, int d)
        {
            for (int i = 0; i < d; i++)
            {
                var elementRotate = a[0];
                a.RemoveAt(0);
                a.Add(elementRotate);
            }

            return a;
        }
    }
}