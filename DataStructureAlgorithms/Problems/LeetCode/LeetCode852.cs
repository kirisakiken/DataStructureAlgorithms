using System;
using System.Linq;

namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     Peak Index in a Mountain Array
    ///     https://leetcode.com/problems/peak-index-in-a-mountain-array/
    /// </summary>
    public class LeetCode852
    {
        /// <summary>
        ///     Linq Solution;
        ///     var list = arr.ToList();
        ///     return list.IndexOf(list.Max());
        /// </summary>
        public int PeakIndexInMountainArray(int[] arr)
        {
            var i = 0;
            while (arr[i] < arr[i + 1])
                ++i;

            return i;
        }
    }
}