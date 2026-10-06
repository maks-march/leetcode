namespace Base75;

public class TopKFrequentItems
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
                freq[num] = 1;
        }
        
        var pq = new PriorityQueue<int, int>();
        foreach (var key in freq.Keys)
        {
            pq.Enqueue(key, -freq[key]);
        }
        int[] ans = new int[k];
        
        for(int i=0; i<k; i++) {
            ans[i] = pq.Dequeue();
        }

        return ans;
    }
}