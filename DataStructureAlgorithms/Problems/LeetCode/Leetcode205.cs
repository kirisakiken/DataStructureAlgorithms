namespace DataStructureAlgorithms.Problems.LeetCode
{
    /// <summary>
    ///     LeetCode 205 - Isomorphic Strings
    ///     https://leetcode.com/problems/isomorphic-strings/
    /// </summary>
    public class LeetCode205
    {
        
    }
    
    // C++ Solution
    // #include <iostream>
    // #include <map>
    // #include <set>
    // 
    // bool isIsomorphic(string s, string t)
    // {  
    //     if (s.length() != t.length())
    //         return false;
    //
    //     std::map<char, char> hash;
    //     std::set<char> set;
    //
    //     for (int i = 0; i < s.length(); ++i)
    //     {
    //         if (set.count(t[i]) == 1)
    //             continue;
    //
    //         hash[s[i]] = t[i];
    //         set.insert(t[i]);
    //     }
    //
    //     for (int i = 0; i < t.length(); ++i)
    //         s[i] = hash[s[i]];
    //
    //     return s == t;
    // }
}