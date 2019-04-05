using System;

namespace PadawansTask11
{
    public static class ArrayExtensions
    {
        public static int? FindIndex(double[] array, double accuracy)
        {
            if ((accuracy < 0) || (accuracy > 1)) throw new ArgumentOutOfRangeException();
            if (array is null) throw new ArgumentNullException();
            if (array.Length < 3) throw new ArgumentException();
            int? index = null;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(SumL(array, i) - SumR(array, i)) <= accuracy)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private static double SumL(double[] arr, int index)
        {
            double sum = 0;
            for (int i = 0; i < index; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        private static double SumR(double[] arr, int index)
        {
            double sum = 0;
            for (int i = index + 1; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
    }
}
