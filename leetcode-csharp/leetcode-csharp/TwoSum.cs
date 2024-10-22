using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp
{
    public class TwoSum
    {
        public int[] Solution()
        {
            //nums = [2, 7, 11, 15], target = 9
            int[] nums = [3, 2, 4];
            int target = 6;

            int[] output = new int[2];

            for (int i = 0; i < nums.Length; i++) 
            {
                // hold loop
                for (int j = i+1; j < nums.Length; j++)
                {
                    // check loop
                    if ((nums[i] + nums[j]) == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        return output;
                    }
                }
            }

            return output;
            
        }
    }
}
