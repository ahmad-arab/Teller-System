using System;
using System.Collections.Generic;
using System.Text;

namespace TellerDesktop
{
    class Math
    {
        public static int Max(int a, int b)
        {
            return a >= b ? a : b;
        }
        public static decimal Max(decimal a, decimal b)
        {
            return a >= b ? a : b;
        }
    }
}
