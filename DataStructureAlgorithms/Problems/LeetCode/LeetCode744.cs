using System.Linq;

namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 744 - Find Smallest Letter Greater Than Target
    ///     https://leetcode.com/problems/find-smallest-letter-greater-than-target/
    /// </summary>
    public class LeetCode744
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            if (target < letters[0])
                return letters[0];
            if (target > letters[letters.Length - 1])
                return letters[0];

            var arr = letters.Distinct().ToArray();

            long left = 0;
            long right = arr.Length - 1;
            long pivot;

            while (left <= right)
            {
                pivot = (left + right) / 2;

                if (arr[pivot] == target)
                {
                    if (pivot + 1 > arr.Length - 1)
                        return arr[0];

                    return arr[pivot + 1];
                }

                if (arr[pivot] > target)
                {
                    if (arr[pivot - 1] < target && pivot != 0)
                        return arr[pivot];

                    right = pivot - 1;
                }

                if (arr[pivot] < target)
                {
                    left = pivot + 1;
                }
            }

            return 'X';
        }
        
        // Optimal Solution
        public char OptimalNextGreatestLetter(char[] letters, char target)
        {
            var left = 0;
            var right = letters.Length;
            int pivot;

            while (left < right)
            {
                pivot = left + (right - left) / 2;

                if (letters[pivot] <= target)
                    left = pivot + 1;

                if (letters[pivot] > target)
                    right = pivot;
            }

            return letters[left % letters.Length];
        }
    }
}