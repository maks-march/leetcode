namespace ConsoleTasks.BinarySearch;

public class SearchInRotated
{
    public int Search(int[] nums, int target)
    {
        if (nums.Length == 1)
            return nums[0] == target ? 0 : -1;
        int cut = FindCut(nums, target);
        return cut;
    }

    private int FindCut(int[] nums, int target)
    {
        if (nums.Length < 2)
            return 0;
        var left = 0;
        var right = nums.Length - 1;
        int center;
        while (left < right)
        {
            center = (left + right) / 2;
            if (target >= nums[center]) // проверка центра
            {
                if (nums[center] == target)
                    return center;
                if (nums[center] < nums[right]) // правая половина не содержит разрыв
                {
                    if (target <= nums[right]) // искомое в правой половине
                    {
                        left = center + 1;
                    }
                    else
                    {
                        // если разрыв в правой половине
                        // но искомое больше центра значит нужно искать в правой
                        right = center - 1;
                    }
                }
                else
                {
                    left = center + 1;
                }
            }
            else // искомое меньше центра
            {
                if (nums[center] < nums[right]) // правая половина не содержит разрыв
                {
                    // если справа разрыва нет а искомое меньше, значит оно в другой части
                    right = center - 1;
                }
                else
                {
                    if (target >= nums[left]) // искомое в левой половине
                    {
                        right = center - 1;
                    }
                    else
                    {
                        // если разрыв в правой половине
                        // и искомого нет в неразрывной значит оно на разрыве
                        left = center + 1;
                    }
                }
            }
        }

        if (right < 0 || nums[right] != target)
            return -1;
        return right;
    }
}