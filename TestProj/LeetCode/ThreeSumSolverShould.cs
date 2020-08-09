using System;
using System.Collections.Generic;
using System.Linq;
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

            actual = actual.OrderBy(x => x.GetHashCode()).ToArray();
            expected = expected.OrderBy(x => x.GetHashCode()).ToArray();
            
            var result = actual.SequenceEqual(expected, new MyComparer());
            
            Assert.True(result);
        }
        
        public class MyComparer : IEqualityComparer<int[]>
        {
            public bool Equals(int[] x, int[] y)
            {
                if (x == null) throw new ArgumentNullException(nameof(x));
                if (y == null) throw new ArgumentNullException(nameof(y));

                return x.OrderBy(val => val).SequenceEqual(y.OrderBy(val => val));
            }

            public int GetHashCode(int[] obj)
            {
                return obj.Sum();
            }
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