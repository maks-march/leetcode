namespace YandexTasks.Easy;

public static class MedianElement
{
    public static void SolveInput()
    {
        Console.WriteLine(Solve(Console.ReadLine()));
    }

    public static int Solve(string? input)
    {
        return input?.Split(' ')
                    .Select(x => int.Parse(x))
                    .Order()
                    .ToArray()
                    .Skip(1).First() ?? -1;
    }
}
