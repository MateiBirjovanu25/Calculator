using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    public static class factorial
    {
        public static double f(double a)
        {
            int s = 1;
            for (int i = 1; i <= a; i++)
                s = s * i;
            return s;
        }
    }
}
