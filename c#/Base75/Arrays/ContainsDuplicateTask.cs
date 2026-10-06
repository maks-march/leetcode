namespace Base75;

public class ContainsDuplicateTask
{
    public bool ContainsDuplicate(int[] nums)
    {
        var hashes = new HashSet<int>();
        foreach (var num in nums)
        {
            if (hashes.Contains(num))
            {
                return true;
            }
            hashes.Add(num);
        }
        return false;
    }
}