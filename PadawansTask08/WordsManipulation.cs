using System.Text;
using System;
using System.Collections.Generic;

namespace PadawansTask8
{
    public static class WordsManipulation
    {
        public static void RemoveDuplicateWords(ref string text)
        {
            string[] str = text.Split(new char[] { '.', ',', '!', '?', '-', ':', ';', ' ' });
            List<string> oneWords = new List<string>();
            string result = "";
            string separator = " ";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == (str.Length - 1)) separator = "";
                if (!oneWords.Contains(str[i]))
                {
                    oneWords.Add(str[i]);
                    result = result + str[i] + separator;
                }
                else
                {
                    result = result + separator;
                }
            }
            text = result;
        }
    }
}