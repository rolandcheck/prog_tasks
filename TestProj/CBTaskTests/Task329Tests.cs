using System.Collections;
using System.Linq;
using LibraryProj.CBTasks;
using NUnit.Framework;

namespace TestProj.CBTaskTests
{
    [TestFixture]
    public class Task329Tests
    {
        [TestCaseSource(typeof(Task329DataProvider), "TestCases")]
        public bool Task329_CorrectOutput(int[] input, int desiredSum)
        {
            // arrange
            var myList = input.Select(x => new SignedNumber(x));


            // act
            var solver = new Task329Solver();
            var result = solver.Solve(myList, desiredSum);


            // assert
            var actualSum = result.Sum();
            return actualSum == desiredSum;
        }

    }

    public class Task329DataProvider
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new[] { 4, 3, 2 }, 1).Returns(true);
                yield return new TestCaseData(new[] { 5, 2, 1, 1 }, 1).Returns(true);
                yield return new TestCaseData(new[] { 5, 2, 7, 1 }, 5).Returns(true);
                yield return new TestCaseData(new[] { 5, 2, 7, 1 }, 4).Returns(false);
                yield return new TestCaseData(new[] { 5, 3, 7, 1 }, 6).Returns(true);
            }
        }
    }
}
