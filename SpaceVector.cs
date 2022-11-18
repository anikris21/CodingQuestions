using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public class SpaceVector
    {
        public int[] nums;

        public SpaceVector(int[] nums)
        {
            this.nums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                this.nums[i] = nums[i];
            }
        }

        public int DotProduct(SpaceVector vec)
        {
            int val = 0;
            for (int i = 0;i< this.nums.Length;i++)
            {
                val += this.nums[i] * vec.nums[i];
            }

            return val;
        }
    }
}
