namespace RandomTasks;

public static class NumberOfIslands
{
    public static int NumIslands(char[][] grid) {
        var st = new Stack<(int x, int y)>();
        var hs = new HashSet<(int, int)>();
        var directions = new (int x, int y)[] {(0, -1), (0, 1), (1, 0), (-1, 0)};
        var height = grid.Length;
        var width = grid[0].Length;
        var result = 0;

        IList<IList<int>> a = new List<IList<int>>();
        var b = new HashSet<int>();
        
        a.Add([1, 2, 3]);
        for (var i = 0; i < width; i++) {
            for (var j = 0; j < height ; j++) {
                var p = grid[j][i];
                (int x, int y) c = (i, j);
                if (!hs.Contains(c) && p == '1') {
                    result++;
                    st.Push(c);
                    hs.Add(c);
                    while (st.Count > 0) {
                        var n = st.Pop();
                        var (x, y) = n;
                        if (grid[y][x] == '0') {
                            continue;
                        }
                        var newPoints = directions
                            .Select(point => (x+point.x, y+point.y))
                            .Where(point => !hs.Contains(point) && 0 <= point.Item2 && point.Item2 < height && 0 <= point.Item1 && point.Item1 < width)
                            .ToList();
                        foreach (var newPoint in newPoints) {
                            hs.Add(newPoint);
                            st.Push(newPoint);
                        }
                    }
                }
            }
        }
        return result;
    }
}