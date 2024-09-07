using System;
using Xunit;

namespace top_interview_questions.easy_collection;

// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/727/
public class RemoveDuplicatesFromSortedArray
{
    private static int Solution(int[] nums){
        var len = nums.Length;
        var last = Int32.MinValue;
        var cont = 0;
        
        for (var i = 0; i < len; i++) {
            if (nums[i] != last) {
                nums[cont] = nums[i];
                last = nums[i];
                cont++;
            }
        }
        return cont;
    }
    
    [Theory]
    [InlineData(new[] {1,1,2}, new[] {1,2,2}, 2)]
    [InlineData(new[] {0,0,1,1,1,2,2,3,3,4}, new[] {0,1,2,3,4,2,2,3,3,4}, 5)]
    public void Test(int[] nums, int[] expected, int k) {
        Assert.Equal(k, Solution(nums));
        Assert.Equal(expected, nums);
    }
}