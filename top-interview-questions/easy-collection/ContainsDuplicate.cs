namespace top_interview_questions.easy_collection;

// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/578/
public class ContainsDuplicate
{
    private static bool Solution(int[] nums)
    {
        nums = nums.OrderBy(x => x).ToArray();

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] == nums[i])
                return true;
        }
        
        return false;
    }
    
    [Theory]
    [InlineData(new[] {1,2,3,1}, true)]
    [InlineData(new[] {1,2,3,4}, false)]
    [InlineData(new[] {1,1,1,3,3,4,3,2,4,2}, true)]
    public void Test(int[] nums, bool expected) {
        Assert.Equal(expected, Solution(nums));
    }
}