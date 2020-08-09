using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace LibraryProj.LeetCode.ArrayTargetSum
{
    
    public class ThreeSumSolver
    {
        public int[][] Solve(int[] nums)
        {
            var result = new HashSet<(int,int,int)>();

            Array.Sort(nums);

            for (var i = 0; i < nums.Length - 2; i++)
            {
                var leftIndex = i + 1;
                var rightIndex = nums.Length - 1;

                while (leftIndex < rightIndex)
                {
                    var tempSum = nums[i] + nums[leftIndex] + nums[rightIndex];

                    if (tempSum == 0)
                    {
                        var valueTuple = (nums[i], nums[leftIndex], nums[rightIndex]);
                        
                        if (!result.Contains(valueTuple))
                        {
                            result.Add(valueTuple);
                        }
                        
                        rightIndex--;
                        leftIndex++;
                    }

                    if (tempSum > 0)
                    {
                        rightIndex--;
                    }

                    if (tempSum < 0)
                    {
                        leftIndex++;
                    }
                }                
            }

            
            return result.Select(x=> new[] {x.Item1,x.Item2,x.Item3}).ToArray();
        }
    }
}