namespace ConsoleTasks;

public class TwoSumTask
{
    public int[] TwoSum(int[] nums, int target) {
        var otherNums = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (otherNums.TryGetValue(num, out int index))
            {
                return new[] {i,  index};
            }
            otherNums[target - num] = i;
        }
        throw new ArgumentException();
    }
}