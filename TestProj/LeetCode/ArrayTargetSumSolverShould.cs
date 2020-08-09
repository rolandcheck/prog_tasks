using System.Collections.Generic;
using LibraryProj.LeetCode.ArrayTargetSum;
using NUnit.Framework;

namespace TestProj.LeetCode
{
    [TestFixture]
    public class ArrayTargetSumSolverShould
    {
        private TwoSumSolver _solver;

        [OneTimeSetUp]
        public void Init()
        {
            _solver = new TwoSumSolver();
        }


        [TestCaseSource(nameof(CorrectTestCases))]
        public int[] ReturnCorrectResult(int[] nums, int target)
        {
            return _solver.Solve(nums, target);
        }

        private static IEnumerable<TestCaseData> CorrectTestCases()
        {
            yield return new TestCaseData(new[] {2, 7, 11, 15}, 9).Returns(new[] {0, 1});
            yield return new TestCaseData(new[] {2, 7, 11, 15}, 13).Returns(new[] {0, 2});
            yield return new TestCaseData(new[] {2, 7, 11, 15}, 22).Returns(new[] {1, 3});
        } 
    }
}
