using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 742 - Find Pivot Index
    ///     https://leetcode.com/problems/find-pivot-index/
    ///     O(n) - time
    ///     O(1) - space
    /// </summary>
    public class LeetCode724
    {
        public int PivotIndex(int[] nums)
        {
            var sum = nums.Sum();
            var leftSum = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                // nums[i] = PIVOT
                if (leftSum == sum - leftSum - nums[i])
                    return i;

                leftSum += nums[i];
            }

            return -1;
        }
    }
}