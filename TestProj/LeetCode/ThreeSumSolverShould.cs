using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using LibraryProj.LeetCode.ArrayTargetSum;
using NUnit.Framework;

namespace TestProj.LeetCode
{
    [TestFixture]
    public class ThreeSumSolverShould
    {
        private ThreeSumSolver _solver;

        [OneTimeSetUp]
        public void Init()
        {
            _solver = new ThreeSumSolver();
        }

        [TestCaseSource(nameof(CorrectTestCases))]
        public void ReturnCorrectResult(int[] nums, int[][] expected)
        {
            var actual = _solver.Solve(nums);

            actual.Should().BeEquivalentTo(expected);
        }
        
        
        private static IEnumerable<TestCaseData> CorrectTestCases()
        {
            yield return new TestCaseData(new[] {-1, 0, 1, 2, -1, -4}, new[] {
                new[] {-1, 0, 1}, 
                new[] {-1, -1, 2},
            });
        } 
    }
}