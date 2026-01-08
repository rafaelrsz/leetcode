namespace _14weeks_faang.week1;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class RemoveDuplicatesFromSortedArray
{
    private static int Solution(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int pivot = 1;

        for(int i=0; i<nums.Length-1; i++)
        {
            if(nums[i] != nums[i+1])
            {
                nums[pivot] = nums[i + 1];
                pivot++;
            }
        }

        return pivot;
    }

    [Theory]
    [InlineData(
        new[] { 1, 1, 2 },
        new[] { 1, 2 },
        2
    )]
    [InlineData(
        new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 },
        new[] { 0, 1, 2, 3, 4 },
        5
    )]

    public void Test(int[] nums, int[] expectedNums, int expectedK)
    {
        int k = Solution(nums);

        Assert.Equal(expectedK, k);

        for (int i = 0; i < k; i++)
        {
            Assert.Equal(expectedNums[i], nums[i]);
        }
    }
}