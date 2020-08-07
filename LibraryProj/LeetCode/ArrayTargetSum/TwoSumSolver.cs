using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TwoSum
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
        /// <exception cref="InvalidOperationException"></exception>
        public int[] Solve(int[] nums, int target)
        {
            var bag = new Dictionary<int, int>();
            
            for (var i = 0; i < nums.Length; i++)
            {
                var residue = target - nums[i];
                
                if (bag.ContainsKey(residue))
                {
                    return new[] {bag[residue], i};
                } 
                
                bag.Add(nums[i], i);
            }

            throw new TwoSumSolverException($"There is no two numbers that sum to target {target}");
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
