using Xunit;

namespace top_interview_questions.easy_collection;

public class RotatedArray
{
    private static void Solution(int[] nums, int k)
    {
        int l = 0, r = nums.Length - 1;
        k = k % nums.Length;
        
        // Reverse entire array
        while (l < r)
        {
            (nums[l], nums[r]) = (nums[r], nums[l]);

            l++;
            r--;
        }

        l = 0;
        r = k -1;
        
        // Reverse first part 
        while (l < r)
        {
            (nums[l], nums[r]) = (nums[r], nums[l]);

            l++;
            r--;
        }
        
        l = k;
        r = nums.Length -1;
        
        // Reverse second part 
        while (l < r)
        {
            (nums[l], nums[r]) = (nums[r], nums[l]);

            l++;
            r--;
        }

    }
    
    [Theory]
    [InlineData(new[] {1,2,3,4,5,6,7}, 3, new[] {5,6,7,1,2,3,4})]
    [InlineData(new[] {-1,-100,3,99}, 2, new[] {3,99,-1,-100})]
    public void Test(int[] nums, int k, int[] expected)
    {
        Solution(nums, k);
        Assert.Equal(expected, nums);
    }
}