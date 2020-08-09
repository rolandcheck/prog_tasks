using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using FluentAssertions;
using LibraryProj.LeetCode;
using NUnit.Framework;

namespace TestProj.LeetCode
{
    [TestFixture]
    public class DuplicateRemoveSolverShould
    {
        private DuplicateRemoveSolver _solver;

        [OneTimeSetUp]
        public void Init()
        {
            _solver = new DuplicateRemoveSolver();
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void ReturnCorrectResult(int[] nums, int expected, int[] outputArray)
        {
            var actual = _solver.RemoveDuplicates(nums);

            actual.Should().Be(expected);

            nums.Take(actual).Should().Equal(outputArray);
        }

        private static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(new[] {1, 1, 2}, 2, new[] {1, 2});
            yield return new TestCaseData(new[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4}, 5, new[] {0, 1, 2, 3, 4});
            yield return new TestCaseData(new[] {1, 1}, 1, new[] {1});
            yield return new TestCaseData(new[] {1}, 1, new[] {1});
            yield return new TestCaseData(new[] {1, 2}, 2, new[] {1, 2});
            yield return new TestCaseData(new int[] {}, 0, new int[] {});

        }
    }
}