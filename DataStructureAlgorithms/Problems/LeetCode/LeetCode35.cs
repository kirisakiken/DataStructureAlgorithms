using System;

namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 35 - Search Insert Position
    ///     https://leetcode.com/problems/search-insert-position/
    /// </summary>
    public class LeetCode35
    {
        public int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            int pivot;

            while (left <= right)
            {
                pivot = (left + right) / 2;
                if (nums[pivot] == target)
                    return pivot;

                if (nums[pivot] > target)
                    right = pivot - 1;

                if (nums[pivot] < target)
                    left = pivot + 1;
            }

            return left;
        }
    }
}