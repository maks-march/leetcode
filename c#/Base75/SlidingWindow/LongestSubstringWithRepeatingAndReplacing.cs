namespace Base75.SlidingWindow;

public class LongestSubstringWithRepeatingAndReplacing
{
    public int CharacterReplacement(string s, int k)
    {
        var left = 0;
        var maxLength = 0;
        var dict = new int[26];
        for (int right = 0; right < s.Length; right++)
        {
            var ind = s[right] - 'A';
            dict[ind]++;
            var substrLength = right - left + 1;
            if (substrLength - dict.Max() <= k)
            {
                maxLength = Math.Max(maxLength, substrLength);
            }
            else
            {
                while (left < right && substrLength - dict.Max() > k)
                {
                    ind = s[left] - 'A';
                    dict[ind]--;
                    left++;
                    substrLength = right - left + 1;
                }
            }
        }
        return maxLength;
    }
}