namespace YandexTasks.Easy;

public class MaxCost
{
    public static void SolveInput()
    {
        int[,] table = Parse();
        var res = Solve(table);
        Console.WriteLine(res);
        Console.WriteLine(FindPath(table));
    }

    public static int[,] Parse()
    {
        var parsed = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int[,] table = new int[parsed[0], parsed[1]];
        for (int i = 0; i < parsed[0]; i++)
        {
            var line = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < parsed[1]; j++)
            {
                table[i, j] = line[j];
            }
        }
        return table;
    }

    public static int Solve(int[,] table)
    {
        for (int x = 0; x < table.GetLength(1); x++)
        {
            for (int y = 0; y < table.GetLength(0); y++)
            {
                if (x == 0)
                {
                    table[y, x] += y - 1 < 0 ? 0 : table[y - 1, x];
                }
                else if (y == 0)
                {
                    table[y, x] += x - 1 < 0 ? 0 : table[y, x - 1];
                }
                else
                {
                    table[y, x] += table[y, x - 1] < table[y - 1, x] ? table[y - 1, x] : table[y, x - 1];
                }
            }
        }
        return table[table.GetLength(0) - 1, table.GetLength(1) - 1];
    }
    
    public static string FindPath(int[,] table)
    {
        var (x, y) = (table.GetLength(1) - 1, table.GetLength(0) - 1);
        string result = "";
        while (x > 0 || y > 0)
        {
            bool goDown = y > 0 && (x == 0 || table[y - 1, x] > table[y, x - 1]);

            if (goDown)
            {
                y--;
                result = "D " + result; 
            }
            else
            {
                x--;
                result = "R " + result;
            }
        }
        return result.ToString().Trim();
    }
}
