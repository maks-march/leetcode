namespace Base75;

public class ThreeSumTask {
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var hashSet = new HashSet<(int, int, int)>();
        var result = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1] && nums[i] != 0)
                continue;
            var num = nums[i];
            var left = i+1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var sum = num + nums[left] + nums[right];
                if (sum == 0)
                {
                    if (!hashSet.Contains((num, nums[left], nums[right])))
                    {
                        hashSet.Add((num, nums[left], nums[right]));
                        result.Add(new []{ num, nums[left], nums[right] });
                    }
                    left++;
                    right--;
                } else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
        
        return result.ToArray<IList<int>>();
    }
}