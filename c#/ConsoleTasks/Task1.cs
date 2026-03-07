using System.Text;

namespace ConsoleTasks;

public class Task1
{
    public int MinFlips(string s)
    {
        if (s.Any(x => x != '0' && x != '1'))
            throw new ArgumentException("String contains invalid characters");
        int n = s.Length;
        if (n < 2)
            return 0;
        
        int alternateNums = CountMostAlternateCases(n, CountPrefixSumZeroFirst(s));
        return s.Length - alternateNums;
    }

    private int CountMostAlternateCases(int len, int[] posCache)
    {
        var maxAlternateNums = 0;
        for (int i = 0; i < len; i++)
        {
            var altOnZeroFirst = FindNewAlternate(len, i, posCache);
            maxAlternateNums = int.Max(maxAlternateNums, len - altOnZeroFirst);
            maxAlternateNums = int.Max(maxAlternateNums, altOnZeroFirst);
        }
        return maxAlternateNums;
    }
    
    public int[] CountPrefixSumZeroFirst(string s)
    {
        int n = s.Length;
        int[] zeroFirstPrefixSumCache = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0 && s[i] == '0' || s[i] == '1' && i % 2 == 1)
                zeroFirstPrefixSumCache[i]++;
            if (i > 0)
                zeroFirstPrefixSumCache[i] += zeroFirstPrefixSumCache[i - 1];
        }
        return zeroFirstPrefixSumCache;
    }

    public int FindNewAlternate(int len, int start, int[] prefix = default)
    {
        var newSegment = start == 0 ? 0 : prefix[start-1];
        var oldSegment = prefix[len - 1] - newSegment;
        if (start % 2 == 1)
        {
            oldSegment = len - start - oldSegment;
        }
        if ((len - start) % 2 == 1)
        {
            newSegment = start - newSegment;
        }

        return oldSegment + newSegment;
    }

    private int CountAlternateCases(int current, string s)
    {
        var result = 0;
        var isOdd = true;
        for (int i = 0; i < s.Length; i++)
        {
            char x = s[current];
            if (isOdd && x == '0' || !isOdd && x == '1')
                result++;
            isOdd = !isOdd;
            current++;
            if (current > s.Length - 1)
                current = 0;
        }

        return result;
    }

    public int CountAlternateCases(string s)
    {
        return CountAlternateCases(0, s);
    }

    private StringBuilder Flip(StringBuilder sb, int index)
    {
        if (index < 0 || index >= sb.Length)
            throw new ArgumentOutOfRangeException(nameof(index));
        sb[index] = sb[index] == '1' ? '0' : '1';
        return sb;
    }

    public string Flip(string s, int index)
    {
        var sb = new StringBuilder(s);
        sb =  Flip(sb, index);
        return sb.ToString();
    }
    
    private StringBuilder Pull(StringBuilder sb)
    {
        if (sb.Length == 0)
            throw new ArgumentException("Empty stringbuilder");
        sb.Append(sb[0]);
        sb.Remove(0, 1);
        return sb;
    }

    public string Pull(string s)
    {
        var sb = new StringBuilder(s);
        sb = Pull(sb);
        return sb.ToString();
    }
}