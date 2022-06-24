using System.Collections.Generic;
using System.Threading;

namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 278 - First Bad Version
    ///     https://leetcode.com/problems/first-bad-version/
    /// </summary>
    public class LeetCode278
    {
        /// <remarks>
        ///     Mock method to call API
        /// </remarks>
        public virtual bool IsBadVersion(int version)
        {
            return false;
        }

        public int FirstBadVersion(int n)
        {
            var pivot = n;
            while (IsBadVersion(pivot))
                pivot /= 2;

            while (!IsBadVersion(pivot))
                ++pivot;

            return pivot;
        }

        // Optimized version - ~%65 faster
        public int OptimizedFirstBadVersion(int n)
        {
            var left = 1;
            var right = n;

            while (left < right)
            {
                var mid = (left + right) >> 1;
                if (IsBadVersion(mid))
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            if (IsBadVersion(left))
                return left;

            return left + 1;
        }
    }
}