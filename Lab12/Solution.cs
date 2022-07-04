using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class Solution
    {
        static public double GetLength(double r)
        {
            return 2 * Math.PI * r;
        }
        public static double GetArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public static bool GetBelong(double x, double y, double r)
        {
            if (Math.Sqrt(x * x + y * y) > r)
                return false;
            return true;
        }
    }
}
