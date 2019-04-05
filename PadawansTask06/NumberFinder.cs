using System;
using System.Collections.Generic;

namespace PadawansTask6
{
    public static class NumberFinder
    {
        public static int? NextBiggerThan(int number)
        {
            if (number < 0) throw new ArgumentException();
            List<char> inNum = IntToList(number); // преобразуем в коллекцию символов
            if (inNum.Count < 2) return null;
            List<char> rigth_num = new List<char>();

            int max_pos = inNum.Count - 1;
            int separate_pos = 0;
            for (int i = 0; i < inNum.Count; i++)
            {
                if (i == max_pos) return null;
                if (inNum[max_pos - i] > inNum[max_pos - i - 1])
                {
                    separate_pos = max_pos - i - 1;
                    rigth_num.Add(inNum[max_pos - i]);
                    break;
                }
                else
                {
                    rigth_num.Add(inNum[max_pos - i]);
                }
            }
            for (int i = 0; i < rigth_num.Count; i++)
            {
                if (inNum[separate_pos] < rigth_num[i])
                {
                    char tmp = rigth_num[i];
                    rigth_num[i] = inNum[separate_pos];
                    inNum[separate_pos] = tmp;
                    break;
                }
            }
            List<char> res = new List<char>();
            res.AddRange(inNum.GetRange(0, separate_pos + 1));
            res.AddRange(rigth_num);
            return ListToInt(res);
        }
        private static int? ListToInt(List<char> list)
        {
            try
            {
                string res_string = "";
                foreach (char c in list)
                {
                    res_string = res_string + c;
                }
                return int.Parse(res_string);
            }
            catch (Exception e)
            {
                return null;
            }
        }
        private static List<char> IntToList(int i)
        {

            List<char> result = new List<char>();
            string str = Convert.ToString(i);
            for (int pos = 0; pos < str.Length; pos++)
            {
                result.Add(str[pos]);
            }
            return result;
        }


    }
}
