using Xunit;

namespace top_interview_questions.easy_collection;

// https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
public class BestTimeToBuyAndSellStockTwo
{
    private static int Solution(int[] prices)
    {
        int k = 0;
        for(var i= 0; i<prices.Length - 1; i++)
        {
            if (prices[i + 1] > prices[i])
            {
                k += prices[i + 1] - prices[i];
            }
        }

        return k;
    }
    
    [Theory]
    [InlineData(new[] {7,1,5,3,6,4}, 7)]
    [InlineData(new[] {1,2,3,4,5}, 4)]
    [InlineData(new[] {7,6,4,3,1}, 0)]
    public void Test(int[] nums, int k) {
        Assert.Equal(k, Solution(nums));
    }
}