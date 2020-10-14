using System;

namespace MissingNumberAndRepeatingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(MissingNumber(nums));
        }

        // https://leetcode.com/problems/missing-number/
        static int MissingNumber(int[] nums)
        { //xor
            int sum = nums.Length;
            for (int i = 0; i < nums.Length; i++)
                sum += i - nums[i];
            return sum;

        }


        static int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[nums[0]];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
                if (slow == fast)
                {
                    fast = 0;
                    while (fast != slow)
                    {
                        fast = nums[fast];
                        slow = nums[slow];
                    }
                    return slow;
                }
            }
            return slow;
        }

    }
}
