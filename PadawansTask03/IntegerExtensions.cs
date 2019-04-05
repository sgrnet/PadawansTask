using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if ((a == 0) && (b == 0)) throw new ArgumentException();
            if (b == 0)
                return Math.Abs(a);
            return Gcd(b, a % b);
        }
    }
}
