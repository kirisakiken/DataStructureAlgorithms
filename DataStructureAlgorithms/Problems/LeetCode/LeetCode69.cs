namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 69 - Sqrt(x)
    ///     https://leetcode.com/problems/sqrtx/
    /// </summary>
    public class LeetCode69
    {
        public int MySqrt(int x)
        {
            if (x == 0)
                return 0;

            var left = 1;
            var right = x; 

            while (left <= right)
            {
                long pivot = left + (right - left) / 2;

                var midSquare = pivot * pivot;
                var midRightSquare = (pivot + 1) * (pivot + 1);

                if (midSquare == x)
                    return (int) pivot;
                if (midRightSquare == x)
                    return (int) pivot + 1;
                if (midSquare < x && midRightSquare > x)
                    return (int) pivot;

                if (midSquare > x)
                    right = (int) pivot - 1;
                if (midRightSquare < x)
                    left = (int) pivot + 1;
            }

            return 0;
        }
    }
}