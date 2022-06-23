using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 1385 - Find the Distance Value Between Two Arrays
    ///     https://leetcode.com/problems/find-the-distance-value-between-two-arrays/
    /// </summary>
    public class LeetCode1385
    {
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            var result = 0;
            var sorted = arr2.ToList();
            sorted.Sort();

            foreach (var target in arr1)
                result += BinarySearch(target, sorted, d);

            return result;
        }

        private int BinarySearch(int value, IReadOnlyList<int> targetCollection, int distance)
        {
            var left = 0;
            var right = targetCollection.Count - 1;
            int pivot;

            while (left <= right)
            {
                pivot = (left + right) / 2;

                if (Math.Abs(value - targetCollection[pivot]) <= distance)
                    return 0;

                if (targetCollection[pivot] >= value)
                    right = pivot - 1;

                if (targetCollection[pivot] < value)
                    left = pivot + 1;
            }

            return 1;
        }
    }
}