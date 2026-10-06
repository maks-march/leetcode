namespace Base75.SlidingWindow;

public class MinimumWindowSubstring
{
    public string MinWindow(string s, string t) {
        if (t == "") return "";

        Dictionary<char, int> countT = new Dictionary<char, int>();
        Dictionary<char, int> window = new Dictionary<char, int>();

        foreach (char c in t) {
            if (countT.ContainsKey(c)) {
                countT[c]++;
            } else {
                countT[c] = 1;
            }
        }

        int have = 0, need = countT.Count;
        int[] res = { -1, -1 };
        int resLen = int.MaxValue;
        int l = 0;

        for (int r = 0; r < s.Length; r++) {
            char c = s[r];
            if (window.ContainsKey(c)) {
                window[c]++;
            } else {
                window[c] = 1;
            }

            if (countT.ContainsKey(c) && window[c] == countT[c]) {
                have++;
            }

            while (have == need) {
                if ((r - l + 1) < resLen) {
                    resLen = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }

                char leftChar = s[l];
                window[leftChar]--;
                if (countT.ContainsKey(leftChar) && window[leftChar] < countT[leftChar]) {
                    have--;
                }
                l++;
            }
        }

        return resLen == int.MaxValue ? "" : s.Substring(res[0], resLen);
    }
    
    public string MinWindowSlow(string s, string t) 
    {
        var left = 0;
        var minLength = s.Length;
        var result = "";
        var tDict = new int[52];
        var sDict = new int[52];
        foreach (var ch in t)
        {
            tDict[GetIndex(ch)]++;
        }
        var indexes = new int[s.Length];
        for (var index = 0; index < s.Length; index++)
        {
            var ch = s[index];
            indexes[index] = GetIndex(ch);
        }

        int substrLength = 0;
        int same = 0;
        for (int right = 0; right < s.Length; right++)
        {
            var ind = indexes[right];
            sDict[ind]++;
            substrLength = right - left + 1;
            same = CountSame(sDict, tDict);
            if (same == t.Length && minLength >= substrLength)
            {
                minLength = substrLength;
                result = s.Substring(left, substrLength);
            }
            while (left < right && same == t.Length)
            {
                if (minLength >= substrLength)
                {
                    minLength = substrLength;
                    result = s.Substring(left, substrLength);
                }
                sDict[indexes[left]]--;
                left++;
                substrLength = right - left + 1;
                same = CountSame(sDict, tDict);
            }
            if (same == t.Length && minLength >= substrLength)
            {
                minLength = substrLength;
                result = s.Substring(left, substrLength);
            }
        }
        if (same == t.Length && minLength >= substrLength)
        {
            result = s.Substring(left, substrLength);
        }
        return result;
    }

    private int CountSame(int[] s, int[] t)
    {
        var r = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= t[i] && t[i] != 0)
            {
                r += t[i];
            }
        }
        return r;
    }

    private int GetIndex(char a)
    {
        int ind;
        if (char.IsUpper(a))
        {
            ind = a - 'A';
            ind += 26;
        }
        else
        {
            ind = a - 'a';
        }
        return ind;
    }
}