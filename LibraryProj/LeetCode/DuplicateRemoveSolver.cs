using System;

namespace LibraryProj.LeetCode
{
    /// <summary>
    /// Solves https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class DuplicateRemoveSolver {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums is null || nums.Length == 0) return 0;
            
            var leftIndex = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[leftIndex] == nums[i]) continue;
                
                leftIndex++;
                nums[leftIndex] = nums[i];
            }

            return leftIndex + 1;
        }
    }
}