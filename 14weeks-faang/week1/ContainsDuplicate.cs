namespace _14weeks_faang.week1;

// https://leetcode.com/problems/contains-duplicate/description/
public class ContainsDuplicate
{
    private static bool Solution(int[] nums)
    {
        HashSet<int> hashSet = [];
        foreach (int v in nums)
        {
            if (!hashSet.Add(v))
            {
                return true;
            }
        }

        return false;
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3, 1 }, true)]
    [InlineData(new[] { 1, 2, 3, 4 }, false)]
    [InlineData(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void Test(int[] nums, bool expected)
    {
        Assert.Equal(expected, Solution(nums));
    }
}