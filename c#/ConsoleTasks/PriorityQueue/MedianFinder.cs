namespace ConsoleTasks.PriorityQueue;

public class MedianFinder
{
    private PriorityQueue<int, int> minHeap;
    private PriorityQueue<int, int> maxHeap;

    class MaxHeapComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
    
    public MedianFinder() {
        minHeap = new PriorityQueue<int, int>();
        maxHeap = new PriorityQueue<int, int>(new MaxHeapComparer());
    }
    
    public void AddNum(int num)
    {
        if (maxHeap.Count == 0)
        {
            maxHeap.Enqueue(num, num);
            return;
        }
        var min = minHeap.Count > 0 ? minHeap.Peek() : num;
        var max = maxHeap.Peek();
        if (num <= max)
            maxHeap.Enqueue(num, num);
        else
            minHeap.Enqueue(num, num);

        if (maxHeap.Count > minHeap.Count + 1)
        {
            num = maxHeap.Dequeue();
            minHeap.Enqueue(num, num);
        }
        if (maxHeap.Count + 1 < minHeap.Count)
        {
            num = minHeap.Dequeue();
            maxHeap.Enqueue(num, num);
        }
    }
    
    public double FindMedian()
    {
        if ((minHeap.Count + maxHeap.Count) % 2 != 0)
        {
            if (minHeap.Count > maxHeap.Count)
            {
                return minHeap.Peek();
            }
            return maxHeap.Peek();
        }
        return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
    }
}