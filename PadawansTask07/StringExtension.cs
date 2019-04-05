using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if ((array is null)|| (array.Length == 0)) throw new ArgumentNullException();
            foreach(string s in array)
            {
                if (s is null) throw new ArgumentNullException();
            }

            int count = array.Length;
            string temp;

            for (int j = 0; j< count; j++)
            {

            for(int i = 0; i< count-1 ; i++)
            {
               if (array[i].Length > array[i+1].Length)
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            }
        }
    }
}
