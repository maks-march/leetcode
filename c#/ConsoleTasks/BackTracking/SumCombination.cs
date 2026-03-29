namespace ConsoleTasks.BackTracking;


public class SumCombination
{
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>();

        void dfs(int i, List<int> current, int total)
        {
            if (total == target)
            {
                result.Add(current.ToArray());
                return;
            }

            if (i >= candidates.Length || total > target)
                return;
            current.Add(candidates[i]);
            dfs(i, current, total + candidates[i]);
            current.Remove(candidates[i]);
            dfs(i + 1, current, total);
            
        }
        dfs(0, new(),0);
        return result;
    }
}