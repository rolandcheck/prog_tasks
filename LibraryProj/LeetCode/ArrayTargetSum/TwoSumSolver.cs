using System;
using System.Collections.Generic;

namespace LibraryProj.LeetCode.ArrayTargetSum
{
    /// <summary>
    /// Solves https://leetcode.com/problems/two-sum/ task
    /// </summary>
    public class TwoSumSolver
    {
        /// <summary>
        /// Solves Two Sum task
        /// </summary>
        /// <param name="nums">Array of numbers</param>
        /// <param name="target">Target sum of two numbers from input array</param>
        /// <returns>Array of two number indices that sum up to target</returns>
        /// <exception cref="TwoSumSolverException">Thrown if there is no such two numbers</exception>
        public int[] Solve(int[] nums, int target)
        {
            var bag = new Dictionary<int, int>();
            
            for (var i = 0; i < nums.Length; i++)
            {
                var residue = target - nums[i];
                
                if (bag.TryGetValue(residue, out var index))
                {
                    return new[] {index, i};
                }
                
                bag[nums[i]] = i;
            }

            throw new TwoSumSolverException($"There is no two numbers that sum up to the target {target}");
        }
    }

    public class TwoSumSolverException : Exception
    {
        public TwoSumSolverException()
        {
        }

        public TwoSumSolverException(string str) : base(str)
        {
        }
        
        public TwoSumSolverException(string str, Exception inner)
        {
        }
    }
}
