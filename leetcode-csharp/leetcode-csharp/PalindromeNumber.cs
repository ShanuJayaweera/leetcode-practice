using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp
{
    public class PalindromeNumber
    {
        public bool Solution(int x)
        {
            string value = x.ToString();
            string reverseValue = "";
            for (int i = value.Length-1; i > -1; i--) 
            { 
                reverseValue += value[i];
            }
            if (reverseValue == value) 
            { 
                return true;
            }
            return false;
        }
    }
}
