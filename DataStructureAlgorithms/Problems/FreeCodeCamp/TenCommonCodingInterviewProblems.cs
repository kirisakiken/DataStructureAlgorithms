using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using DataStructureAlgorithms.Problems.LeetCode;

namespace DataStructureAlgorithms.Problems.FreeCodeCamp
{
    public class TenCommonCodingInterviewProblems
    {
        /// <summary>
        ///     LeetCode 242 - Valid Anagram
        ///     https://leetcode.com/problems/valid-anagram/
        /// 
        ///     O(n) - time
        ///     O(n) - space
        /// </summary>
        // C++ Solution
        // bool isAnagram(const std::string& a, const std::string& b)
        // {
        //     if (a.length() != b.length())
        //         return false;
        //
        //     std::map<char, int> hashA;
        //     std::map<char, int> hashB;
        //
        //     for (char c : a)
        //     {
        //         if (hashA[c] == 0)
        //         {
        //             hashA[c] = 1;
        //             continue;
        //         }
        //
        //         ++hashA[c];
        //     }
        //
        //     for (char c : b)
        //     {
        //         if (hashB[c] == 0)
        //         {
        //             hashB[c] = 1;
        //             continue;
        //         }
        //
        //         ++hashB[c];
        //     }
        //
        //     for (char c : a)
        //     {
        //         if (hashA[c] != hashB[c])
        //             return false;
        //     }
        //
        //     return true;
        // }
        public bool ValidAnagram(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            var hashA = new Dictionary<char, int>();
            var hashB = new Dictionary<char, int>();

            foreach (var c in a)
            {
                if (hashA.ContainsKey(c))
                {
                    ++hashA[c];
                    continue;
                }

                hashA.Add(c, 1);
            }

            foreach (var c in b)
            {
                if (hashB.ContainsKey(c))
                {
                    ++hashB[c];
                    continue;
                }

                hashB.Add(c, 1);
            }

            foreach (var (key, value) in hashA)
            {
                if (!hashB.ContainsKey(key))
                    return false;

                if (value != hashB[key])
                    return false;
            }

            return true;
        }

        /// <summary>
        ///     LeetCode 34 - Find First and Last Position of Element in Sorted Array
        ///     https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
        ///
        ///     O(n) - time
        ///     O(1) - space
        /// </summary>
        // C++ Solution
        // int findStart(std::vector<int>& nums, int target)
        // {
        //     if (nums[0] == target)
        //         return 0;
        //
        //     int left = 0;
        //     int right = nums.size() - 1;
        //
        //     while (left <= right)
        //     {
        //         int pivot = (left + right)  >> 1;
        //
        //         if (nums[pivot] == target && nums[pivot - 1] < target)
        //             return pivot;
        //
        //         if (nums[pivot] < target)
        //         {
        //             left = pivot + 1;
        //             continue;
        //         }
        //
        //         if (nums[pivot] > target)
        //         {
        //             right = pivot - 1;
        //             continue;
        //         }
        //     }
        //
        //     return -1;
        // }
        //
        // int findEnd(std::vector<int>& nums, int target)
        // {
        //     if (nums[nums.size() - 1] == target)
        //         return nums.size() - 1;
        //
        //     int left = 0;
        //     int right = nums.size() - 1;
        //
        //     while (left <= right)
        //     {
        //         int pivot = (left + right) >> 1;
        //
        //         if (nums[pivot] == target && nums[pivot + 1] > target)
        //             return pivot;
        //
        //         if (nums[pivot] < target)
        //         {
        //             left = pivot + 1;
        //             continue;
        //         }
        //
        //         if (nums[pivot] > target)
        //         {
        //             right = pivot - 1;
        //             continue;
        //         }
        //     }
        //
        //     return -1;
        // }
        //
        // std::vector<int> searchRange(std::vector<int>& nums, int target)
        // {
        //     std::vector<int> result;
        //
        //     if (nums.empty() || nums[0] > target || nums[nums.size() - 1] < target)
        //     {
        //         result.push_back(-1);
        //         result.push_back(-1);
        //         return result;
        //     }
        //
        //     result.push_back(findStart(nums, target));
        //     result.push_back(findEnd(nums, target));
        //     return result;
        // }
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0 || nums[0] > target || nums[nums.Length - 1] < target)
                return new[] {-1, -1};

            var start = FindStart(nums, target);
            var end = FindEnd(nums, target);

            return new[] {start, end};
        }

        public int FindStart(int[] nums, int target)
        {
            if (nums.Length == 0)
                return 0;

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var pivot = left + (right - left) / 2;

                if (nums[pivot] == target && nums[pivot - 1] < target)
                    return pivot;

                if (nums[pivot] < target)
                {
                    left = pivot + 1;
                    continue;
                }
                else
                {
                    right = pivot - 1;
                    continue;
                }
            }

            return -1;
        }

        public int FindEnd(int[] nums, int target)
        {
            if (nums[nums.Length - 1] == target)
                return nums.Length - 1;

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var pivot = left + (right - left) / 2;

                if (nums[pivot] == target && nums[pivot + 1] > target)
                    return pivot;

                if (nums[pivot] > target)
                {
                    right = pivot - 1;
                    continue;
                }
                else
                {
                    left = pivot + 1;
                    continue;
                }
            }

            return -1;
        }

        /// <summary>
        ///     Leetcode 215 - Kth Largest Element in an Array
        ///     https://leetcode.com/problems/kth-largest-element-in-an-array/
        /// </summary>
        // C++ Solution
        // int findKthLargest(std::vector<int>& nums, int k)
        // {
        //     std::vector<int> values;
        //     for (int i = 0; i < nums.size(); ++i)
        //         values.push_back(std::numeric_limits<int>::min());
        //
        //     for (int i = 0; i < nums.size(); ++i)
        //     {
        //         for (int j = 0; j < k; ++j)
        //         {
        //             if (nums[i] >= values[j])
        //             {
        //                 values.insert(values.begin() + j, nums[i]);
        //                 j = k;
        //             }
        //         }
        //     }
        //
        //     return values[k - 1];
        // }
        // C++ Solution by Sorting
        // int findKthLargest(std::vector<int>& nums, int k)
        // {
        //     std::sort(nums.begin(), nums.end());
        //     return nums[nums.size() - k];
        // }
        public int FindKthLargest(int[] nums, int k)
        {
            var arr = nums.ToList();
            arr.Sort();

            return arr[arr.Count - k];
        }
    }
}