using System.Collections.Generic;
using System.Linq;

namespace LibraryProj.CBTasks
{
    public class Task329Solver {

        public Task329Solver() { }

        public IEnumerable<int> Solve(IEnumerable<int> numbers, int desiredSum)
        {
            var localCopy = numbers.ToList();
            var i = 0;
            var iterations = localCopy.Count * 2; // todo: think about upper bound
            while ( i++ < iterations) {

                var allSum = localCopy.Sum();

                var extra = allSum - desiredSum;
                if ( extra == 0 ) 
                {
                    break;
                }
                var desiredNumberToNegateIndex = localCopy.IndexOf(extra / 2);
                if (desiredNumberToNegateIndex < 0)
                {
                    desiredNumberToNegateIndex = localCopy.ArgMax();
                }

                localCopy[desiredNumberToNegateIndex] *= -1; 
            }

            return localCopy;
        }
    }

    public static class MyExtensions
    {
        public static int ArgMax(this IEnumerable<int> numbers) {
            var max = numbers.Select((value, index) => new { value, index })
                 .OrderByDescending(x => x.value)
                 .First();

            return max.index;
        }
    }
}
