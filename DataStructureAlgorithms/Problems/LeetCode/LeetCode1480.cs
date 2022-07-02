namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 1480 - Running Sum of 1d Array
    ///     https://leetcode.com/problems/running-sum-of-1d-array/
    /// </summary>
    public class LeetCode1480
    {
        public int[] RunningSum(int[] nums)
        {
            var res = new int[nums.Length];
            res[0] = nums[0];
            for (var i = 1; i <= nums.Length - 1; ++i)
                res[i] = res[i - 1] + nums[i];

            return res;
        }
    }
}