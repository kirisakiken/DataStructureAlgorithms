namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 367 - Valid Perfect Square
    ///     https://leetcode.com/problems/valid-perfect-square/
    /// </summary>
    public class LeetCode367
    {
        public bool IsPerfectSquare(int num)
        {
            long left = 1;
            long right = num;

            while (left <= right)
            {
                long pivot = left + (right - left) / 2;
                var pow = pivot * pivot;
                if (pow == num)
                    return true;

                if (pow > num)
                    right = pivot - 1;

                if (pow < num)
                    left = pivot + 1;
            }

            return false;
        }
    }
}