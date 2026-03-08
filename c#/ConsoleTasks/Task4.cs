namespace ConsoleTasks;

public class Task4
{
    public string FindDifferentBinaryString(string[] nums)
    {
        var integers = new List<int>();
        foreach (var num in nums)
        {
            integers.Add(Convert.ToInt32(num, 2));
        }
        var len = Math.Pow(2, nums.Length);
        for (int i = 0; i < len; i++)
        {
            if (!integers.Contains(i))
            {
                var result = Convert.ToString(i, 2);
                if (result.Length < nums.Length)
                {
                    return new string('0', nums.Length - result.Length) + result;
                }
                return result;
            }
        }
        return "";
    }
}