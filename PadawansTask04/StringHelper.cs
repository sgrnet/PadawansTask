using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == "") throw new ArgumentException();
            if (str is null) throw new ArgumentNullException();
            string[] words = str.Split(new char[] { 'a', 'e', 'i', 'o', 'u' });
            return words.Length - 1;
        }
    }
}
