using System.Collections;

namespace leetCode_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Solution s = new Solution();
            if (s.IsValid("{}[]"))
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack stack = new Stack();


            int i = 0;
            int length = s.Length;

            while (i < length)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else if (stack.Count != 0)
                {
                    if (s[i] == ')' && (char)stack.Pop() != '(') return false;
                    else if (s[i] == '}' && (char)stack.Pop() != '{') return false;
                    else if (s[i] == ']' && (char)stack.Pop() != '[') return false;
                }
                i++;
            }
            if (stack.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
