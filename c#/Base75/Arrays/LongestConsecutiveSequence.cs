namespace Base75;

public class LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            set.Add(num);
        }

        var maxConsecutive = 0;
        foreach (var current in nums)
        {
            if (!set.Contains(current - 1))
            {
                int nextConsecutive = current + 1;
                while (set.Contains(nextConsecutive))
                    nextConsecutive++;
                maxConsecutive = Math.Max(maxConsecutive, nextConsecutive - current);
            }
        }
        return maxConsecutive;
    }
}