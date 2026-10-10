using System;
using System.Security.Cryptography.X509Certificates;

namespace YandexTasks.Easy;

public class KnightMove
{
    public static void SolveInput()
    {
        var input = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
        var (n, m) = (input[0], input[1]);
        
        Console.WriteLine(Solve(n, m));
    }

    public static int Solve(int n, int m)
    {
        var res = 0;
        var queue = new Queue<(int x, int y)>();
        queue.Enqueue((0, 0));
        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();
            if (x == n - 1 && y == m - 1)
            {
                res += 1;
                continue;
            }
            if (!(x + 2 > n - 1 || y + 1 > m - 1))
                queue.Enqueue((x + 2, y + 1));
            if (!(x + 1 > n - 1 || y + 2 > m - 1))
                queue.Enqueue((x + 1, y + 2));
        }
        return res;
    }
}
