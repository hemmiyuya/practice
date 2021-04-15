using System;

namespace ArraysMultiplicationCode
{
    /// <summary>
    /// 配列の積の符号を表示するプログラム
    /// </summary>
    public class Solution
    {
        static void Main()
        {
            int[] nums1 = { 0, 2, 5 };
            int[] nums2 = { -5, 2, 5 };
            int[] nums3 = { 5, 2, 5 };
            Console.WriteLine(ArraySign(nums1));
            Console.WriteLine(ArraySign(nums2));
            Console.WriteLine(ArraySign(nums3));
        }

        static int ArraySign(int[] nums)
        {
            int answer = nums[0];
            if (answer > 0)
            {
                answer = 1;
            }
            else if (answer < 0)
            {
                answer = -1;
            }
            else
            {
                answer = 0;
            }
            for (var i = 1; i < nums.Length; i++)
            {
                answer *= nums[i];
                if (answer > 0)
                {
                    answer = 1;
                }
                else if (answer < 0)
                {
                    answer = -1;
                }
                else
                {
                    answer = 0;
                }
            }
            return answer;
        }
    }
}
