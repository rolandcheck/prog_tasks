using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProj.CBTasks
{
    public class SignedNumber
    {
        public SignedNumber(int number)
        {
            Number = number;
        }

        public int Number { get; private set; }

        public void Negate()
        {
            Number *= -1;
        }
        public override string ToString()
        {
            return $"{Number}";
        }
    }

    public class Task329Solver {

        public Task329Solver() { }

        public IEnumerable<SignedNumber> Solve(IEnumerable<SignedNumber> numbers, int desiredSum)
        {
            var localCopy = numbers.ToList();
            var i = 0;
            var iterations = localCopy.Count * 2; // todo: think about upper bound
            while ( i++ < iterations) {

                var allSum = localCopy.Sum();

                var extra = allSum - desiredSum;
                var extraAbs = Math.Abs(extra);
                if (extraAbs == 0)
                {
                    break;
                }

                var desiredNumberToNegate = localCopy.FirstOrDefault(x => x.Number == extra / 2);
                if ( desiredNumberToNegate is null ) {
                    desiredNumberToNegate = localCopy.OrderBy(x => x.Number).Last();
                }

                desiredNumberToNegate?.Negate(); 
            }

            return localCopy;
        }
    }

    public static class MyExtensions {
        public static int Sum(this IEnumerable<SignedNumber> numbers)
        {
            var result = numbers.Sum(x => x.Number);

            return result;
        }
    }
}
