using System;
using System.Collections.Generic;
using System.Linq;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            if (count < 1) throw new ArgumentOutOfRangeException();
            if (count == 1) return number;
            else
            {
                int sum = 0;
                for (int i = 1; i < count; i++)
                {
                    sum = sum + add;
                }
                sum = sum + number;
                return sum + Calculate(number, add, count - 1);
            }
        }
    }
}
