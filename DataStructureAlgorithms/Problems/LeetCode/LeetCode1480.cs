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
    
    // C++ Solution - 0 ms
    // #include <vector>
    //
    // std::vector<int> runningSum(std::vector<int>& nums)
    // {
    //     int sum = 0;
    //     std::vector<int> result;
    //     result.push_back(nums[0]);
    //
    //     for (int i = 1; i < nums.size(); ++i)
    //     {
    //         result.push_back(result[i - 1] + nums[i]);
    //     }
    //
    //     return result;
    // }
}