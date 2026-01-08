namespace _14weeks_faang.week1;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class FindTheDuplicateNumber
{
    private static int Solution(int[] nums)
    {
        int slow = 0;
        int fast = 0;

        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while (slow != fast);

        slow = 0;

        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }

    [Theory]
    [InlineData(new[] { 1, 3, 4, 2, 2 }, 2)]
    [InlineData(new[] { 3, 1, 3, 4, 2 }, 3)]
    [InlineData(new[] { 3, 3, 3, 3, 3 }, 3)]

    public void Test(int[] nums, int expected)
    {
        var original = (int[])nums.Clone();

        int actual = Solution(nums);

        Assert.Equal(expected, actual);
        Assert.Equal(original, nums);
    }
}