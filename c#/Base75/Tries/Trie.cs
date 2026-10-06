namespace Base75.Tries;

// Префиксное дерево (англ. trie, произносится как "трай")
// структура данных для эффективного хранения и получения строковых ключей.
// Существуют различные применения этой структуры данных, например, автозаполнение и проверка орфографии.

public class Trie
{
    private TrieNode _root;
    
    public Trie()
    {
        _root = new TrieNode();
    }
    
    public void Insert(string word)
    {
        var current = _root;
        for (var index = 0; index < word.Length; index++)
        {
            var s = word[index];
            if (current.Chars[s - 'a'] == null)
            {
                current.Chars[s - 'a'] = new TrieNode();
            }
            current = current.Chars[s - 'a'];
        }
        current.IsWord = true;
    }
    
    public bool Search(string word)
    {
        var current = _root;
        foreach (var s in word)
        {
            if (current.Chars[s - 'a'] == null)
            {
                return false;
            }
            current = current.Chars[s - 'a'];
        }
        return current!.IsWord;
    }
    
    public bool StartsWith(string prefix) {
        var current = _root;
        foreach (var s in prefix)
        {
            if (current.Chars[s - 'a'] == null)
            {
                return false;
            }
            current = current.Chars[s - 'a'];
        }
        return true;
    }
}

public class TrieNode
{
    public TrieNode?[] Chars = new TrieNode?[26];
    public bool IsWord = false;
}