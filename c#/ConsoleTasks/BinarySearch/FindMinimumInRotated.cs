namespace ConsoleTasks.BinarySearch;

public class FindMinimumInRotated
{
    public int FindMin(int[] nums)
    {
        if (nums.Length < 2)
            return nums[0];
        var left = 0;
        var right = nums.Length - 1;
        int center = (left + right) / 2;
        while (left < right)
        {
            center = (left + right) / 2;
            if (nums[left] < nums[center] || center == left)
            {
                if (nums[center] < nums[right])
                    return nums[left];
                left = center + 1;
            }
            else
            {
                right = center;
            }
        }
        return nums[right];
    }
}