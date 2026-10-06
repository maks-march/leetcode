namespace ConsoleTasks.Graphs;

public class NumberOfIslands
{
    public int NumIslands(char[][] grid)
    {
        var result = 0;
        var width = grid.Length;
        var height = grid[0].Length;
        void Dfs(int x, int y)
        {
            if (x < 0 || y < 0 
                || x >= width 
                || y >= height 
                || grid[x][y] != '1')
                return;
            grid[x][y] = '0';
            
            Dfs(x+1, y);
            Dfs(x-1, y);
            Dfs(x, y+1);
            Dfs(x, y-1);
        }

        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                if (grid[i][j] == '1')
                {
                    result++;
                    Dfs(i, j);
                }
            }
        }
        return result;
    }
}