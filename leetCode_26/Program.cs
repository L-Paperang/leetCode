namespace leetCode_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 1, 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            Solution s = new Solution();
            int k = s.RemoveDuplicates(ref nums);
            int[] arr = new int[k];
            for(int i = 0; i < k; i++)
            {
                arr[i] = nums[i];
            }
            nums = arr;
            Console.WriteLine($"长度：{k}, 数组：{String.Join(" ",nums)}");
        }
    }
    public class Solution
    {
        public int RemoveDuplicates(ref int[] nums)
        {
            int k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[k])
                {
                    nums[++k] = nums[i];
                }
            }
            k += 1;
            return k;
        }
    }
}
