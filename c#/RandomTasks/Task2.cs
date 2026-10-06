namespace RandomTasks;

public class Task2
{
    public bool CheckOnesSegment(string s)
    {
        var haveOne = false;
        var onOne = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                if (onOne)
                    continue;
                onOne = true;
                
                if (haveOne)
                    return false;
                haveOne = true;
            }
            else
            {
                onOne = false;
            }
        }
        return haveOne;
    }
}