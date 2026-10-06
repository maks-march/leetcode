using System.Text;

namespace Base75.BackTracking;

public class WordSearch
{
    public bool Exist(char[][] board, string word)
    {
        var width = board.Length;
        var height = board[0].Length;
        var hs = new HashSet<(int, int)>();
        
        bool Search(int x, int y, int i)
        {
            if (i == word.Length)
                return true;
            if (x < 0 
                || y < 0 
                || x >= width 
                || y >= height
                || i >= word.Length
                || word[i] != board[x][y]
                || hs.Contains((x, y)))
                return false;
            
            hs.Add((x, y));
            var res= Search(x + 1, y, i+1) 
                      || Search(x, y + 1, i+1) 
                      || Search(x - 1, y, i+1) 
                      || Search(x, y - 1, i + 1);
            hs.Remove((x, y));
            return res;
        }

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (Search(i, j,0)) 
                    return true;
            }
        }
        return false;
    }
}