namespace ConsoleTasks.SlidingWindow;

public class LongestSubstringNoRepeat
{
    public int LengthOfLongestSubstringSlow(string s)
    {
        var left = 0;
        var right = 0;
        var maxLength = 0;
        var hs = new HashSet<char>();
        while (right < s.Length)
        {
            if (hs.Contains(s[right]))
            {
                hs.Remove(s[left]);
                if (left < right)
                {
                    left++;
                }
                else
                {
                    left++;
                    hs.Add(s[right]);
                    right++;
                }
            }
            else
            {
                hs.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }
        }
        return maxLength;
    }
    
    public int LengthOfLongestSubstring(string s)
    {
        var left = 0;
        var maxLength = 0;
        var dict = new Dictionary<char, int>();
        for (int right = 0; right < s.Length; right++)
        {
            if (dict.ContainsKey(s[right]))
            {
                left = Math.Max(dict[s[right]] + 1, left);
            }
            dict[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}