using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source is null) throw new ArgumentNullException();
            if (source.Length == 0) throw new ArgumentException();
            string result = "Yes";
            int[] reverse_source = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                reverse_source[source.Length - 1 - i] = source[i];
            }
            for (int i = 0; i < source.Length; i++)
            {
                if (reverse_source[i] != source[i]) result = "No";
            }
            return result;
        }
    }
}
