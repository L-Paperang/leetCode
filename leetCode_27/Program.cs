namespace leetCode_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int result = Solution.RemoveElement(nums, val);
            Console.WriteLine(String.Join(", ", nums.Take(result)));
        }
    }
    public static class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k++] = nums[i];
                }
            }
            return k;
        }
    }
}
