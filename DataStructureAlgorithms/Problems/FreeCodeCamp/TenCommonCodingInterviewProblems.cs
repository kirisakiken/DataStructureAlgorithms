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
    }
}