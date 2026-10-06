namespace Base75.Tries;

public class WordDictionary {

    private readonly TrieNode _root;
    
    public WordDictionary() {
        _root = new TrieNode();
    }
    
    public void AddWord(string word) 
    {
        var current = _root;
        foreach (var s in word)
        {
            if (current!.Chars[s - 'a'] == null)
            {
                current.Chars[s - 'a'] = new TrieNode();
            }
            current = current.Chars[s - 'a'];
        }
        current!.IsWord = true;
    }
    
    public bool Search(string word)
    {
        return ReqSearch(word, 0, _root);
    }

    private static bool ReqSearch(string word, int start, TrieNode root)
    {
        var current = root;
        for (var index = start; index < word.Length; index++)
        {
            var s = word[index];
            if (s == '.')
            {
                if (index == word.Length - 1)
                    return current!.Chars
                        .Where(c => c != null)
                        .Any(c => c!.IsWord);
                foreach (var node in current!.Chars)
                {
                    if (node != null && ReqSearch(word, index + 1, node))
                        return true;
                }
                return false;
            }
            if (current!.Chars[s - 'a'] == null)
            {
                return false;
            }
            current = current.Chars[s - 'a'];
        }
        return current!.IsWord;
    }
}