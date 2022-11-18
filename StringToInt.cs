using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public static class StringToInt
    {
        public static int stringToInt(string str)
        {
            int ret = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - '0';
                if (val < 0 || val >= 10 )
                {
                    Console.WriteLine($"Invalid INPUT {str}");
                    break;
                }
                ret = (ret *10) + val;
            }

            return ret;
        }
    }
}
