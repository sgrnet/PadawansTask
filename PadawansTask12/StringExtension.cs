using System;

namespace PadawansTask12
{
    public static class StringExtension
    {

        public static bool AllCharactersAreUnique(string source)
        {
            if (source == "") throw new ArgumentException();
            if (source is null) throw new ArgumentNullException();
            bool res = false;
            char[] ch = source.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (UniqueSymbol(ch, i) == false)
                {
                    res = false;
                    break;
                }
                else
                {
                    res = true;
                }
            }
            return res;
        }
        private static bool UniqueSymbol(char[] arr, int index)
        {
            char c = arr[index];
            int inArrCount = 0;
            bool result = false;
            foreach (char sym in arr)
            {
                if (sym == c) inArrCount++;
                if (inArrCount > 1)
                {
                    result = false;
                    break;
                }
                else result = true;
            }
            return result;
        }
    }
}