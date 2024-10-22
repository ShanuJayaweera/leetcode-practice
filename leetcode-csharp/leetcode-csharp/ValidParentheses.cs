using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_csharp
{
    public class ValidParentheses
    {
        public bool Solution(string s)
        {
            
            Dictionary<string, string> paraDic = new Dictionary<string, string>();
            paraDic.Add("(", ")");
            paraDic.Add("[", "]");
            paraDic.Add("{", "}");


            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < s.Length; i++)
            {
                string key = s[i].ToString();

                if (paraDic.TryGetValue(key, out string value))
                {
                    stack.Push(paraDic[key]);
                }
                else
                {
                    // key is not found, it may closing bracket

                    // get next closing bracket
                    if (stack.Count == 0)
                    {
                        return false; // Mismatch (more closing brackets than opening ones)
                    }
                    string nextBracket = stack.Peek();
                    if (nextBracket == key) 
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
