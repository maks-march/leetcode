namespace ConsoleTasks.Stack;

public class ValidParentheses
{
    public bool IsValid(string s)
    {
        if (s.Length < 2)
            return false;
        var st = new Stack<char>();
        var brakes = new Dictionary<char, char>()
        {
            { ']', '[' },
            { '}', '{' },
            { ')', '(' }
        };
        
        foreach (var ch in s)
        {
            if (!brakes.ContainsKey(ch))
            {
                st.Push(ch);
            }
            else
            {
                if (st.Count == 0)
                    return false;
                var brake = st.Pop();
                if (brakes[ch] != brake)
                {
                    return false;
                }
            }
        }
        return st.Count == 0;
    }
}