namespace ConsoleTasks.BinarySearch;

public class SearchInRotated
{
    public int Search(int[] nums, int target)
    {
        if (nums.Length == 1)
            return nums[0] == target ? 0 : -1;
        int cut = FindCut(nums);
        if (cut != 0)
        {
            int res1 = BinarySearch(nums[..cut], target);
            if (res1 != -1)
            {
                return res1;
            }
        }
        int res2 = BinarySearch(nums[cut..], target);
        return res2 != -1 ? res2 + cut : -1;
    }

    private int BinarySearch(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        int center;
        while (left < right)
        {
            center = (left + right) / 2;

            if (target <= nums[center])
            {
                right = center;
            }
            else
            {
                left = center + 1;
            }
        }

        if (nums[left] != target)
            return -1;
        return left;
    }

    private int FindCut(int[] nums)
    {
        if (nums.Length < 2)
            return 0;
        var left = 0;
        var right = nums.Length - 1;
        int center = (left + right) / 2;
        while (left < right)
        {
            center = (left + right) / 2;
            if (nums[left] < nums[center] || center == left)
            {
                if (nums[center] < nums[right])
                    return left;
                left = center + 1;
            }
            else
            {
                right = center;
            }
        }

        return right;
    }
}