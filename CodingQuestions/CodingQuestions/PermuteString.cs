using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class PermuteString
    {
        public void Permute(string str, string buff, string rem)
        {
            if (str.Length == buff.Length)
            {
                Console.WriteLine(buff);
                return;
            }

            for (int i = 0; i < rem.Length; i++)
            {
                rem = Swap(rem, 0, i);
                var buff1 = buff + rem[0];
                var rem1 = getRemaning(rem);
                rem = Swap(rem, i, 0);

                Permute(str, buff1, rem1);
            }
        }

        private string getRemaning(string rem)
        {
            //char[] cArray = rem.ToCharArray();
            //rem = Swap(rem, 0, index);
            return rem.Remove(0, 1);
        }

        public string SwapXor(string str, int index)
        {
            char[] cArray = str.ToCharArray();
            if (cArray[index] != cArray[0])
            {
                cArray[index] = (char)(cArray[index] ^ cArray[0]);
                cArray[0] = (char)(cArray[index] ^ cArray[0]);
                cArray[index] = (char)(cArray[index] ^ cArray[0]);
            }
            return string.Join("", cArray);
        }

        public string Swap(string str, int index1, int index11)
        {
            char[] cArray = str.ToCharArray();
            char c = cArray[index1];
            cArray[index1] = cArray[index11];
            cArray[index11] = c;

            return string.Join("", cArray);
        }

    }
}
