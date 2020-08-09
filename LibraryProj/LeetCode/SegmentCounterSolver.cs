using System;
using System.Linq;

namespace LibraryProj.LeetCode
{
    /// <summary>
    /// Solves https://leetcode.com/problems/number-of-segments-in-a-string/
    /// </summary>
    public class SegmentCounterSolver
    {
        public int CountSegments(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;

            return s.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}