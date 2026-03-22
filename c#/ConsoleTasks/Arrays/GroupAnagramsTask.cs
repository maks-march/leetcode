namespace ConsoleTasks;

public class GroupAnagramsTask
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagrams = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var chars = str.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);
            if (anagrams.ContainsKey(key))
                anagrams[key].Add(str);
            else
                anagrams[key] = new List<string> { str };
        }
        return anagrams.Values.ToArray<IList<string>>();
    }
}