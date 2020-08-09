using System.Collections.Generic;
using FluentAssertions;
using LibraryProj.LeetCode;
using NUnit.Framework;

namespace TestProj.LeetCode
{
    [TestFixture]
    public class SegmentCounterShould
    {
        private SegmentCounterSolver _solver;

        [OneTimeSetUp]
        public void Init()
        {
            _solver = new SegmentCounterSolver();
        }
        
        [TestCaseSource(nameof(TestCases))]
        public void ReturnCorrectResult(string input, int expected)
        {
            var actual = _solver.CountSegments(input);

            actual.Should().Be(expected);
        }

        private static IEnumerable<TestCaseData> TestCases()
        {
            yield return new TestCaseData(", , , ,        a, eaefa", 6);
            yield return new TestCaseData("Hello, my name is John", 5);

        }
    }
}