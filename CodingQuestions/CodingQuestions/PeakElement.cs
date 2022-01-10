using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class PeakElement
    {
        public int getPeakElement(int[] array)
        {
            int n = array.Length;
            int l = 0, h = n - 1;


            while(l < h)
            {
                int mid = (l + h) / 2;
                if(array[mid] > array[mid+1])
                {
                    h = mid;
                } else
                {
                    l = mid+1;
                }
            }
            return array[l];
        }
    }
}
