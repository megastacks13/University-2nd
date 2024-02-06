using System;
using System.Runtime.CompilerServices;

namespace TPP.Lab02
{
    public static class IntExtension
    {
       public static int Reverse(this int x)
        {
            int r = 0;
            while (x > 0)
            {
                r = r * 10 + x % 10;
                x = x / 10;
            }
            return r;
        }

        public static bool IsPrime(this int x)
        {
            for (int i = x-1; i > 1; i--)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
