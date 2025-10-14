public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        IList<int> res = [];
        foreach (var word in words) {
            res.append(word.count(x));
        }
        return res;
    }
}