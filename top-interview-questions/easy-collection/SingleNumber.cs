namespace top_interview_questions.easy_collection;

// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/549/
public class SingleNumber
{
    private static int Solution(int[] nums)
    {
        int k = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            k = k ^ nums[i];
        }

        return k;
    }
    
    [Theory]
    [InlineData(new[] {2,2,1}, 1)]
    [InlineData(new[] {4,1,2,1,2}, 4)]
    [InlineData(new[] {1}, 1)]
    public void Test(int[] nums, int k) {
        Assert.Equal(k, Solution(nums));
    }
}