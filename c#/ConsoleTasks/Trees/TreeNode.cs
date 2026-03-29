namespace ConsoleTasks.Trees;

public class TreeNode 
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    
    public static TreeNode ToTree(List<int?> values)
    {
        var i = 0;
        var head = values[i] != null ? new TreeNode((int)values[i]!) : null;
        if (head != null)
            AddNodes(head, values, i);
        return head!;
    }

    private static void AddNodes(TreeNode head, List<int?> values, int i)
    {
        if (2 * i + 1 < values.Count && values[2 * i + 1] != null)
        {
            head.left = new TreeNode((int)values[2 * i + 1]!);
            AddNodes(head.left, values, 2 * i + 1);
        }
        if (2 * i + 2 < values.Count && values[2 * i + 2] != null)
        {
            head.right = new TreeNode((int)values[2 * i + 2]!);
            AddNodes(head.right, values, 2 * i + 2);
        }
    }

    public List<int?> ToList()
    {
        var depth = new MaxDepthTask().MaxDepth(this);
        var result = new List<int?>((int)Math.Pow(2, depth));
        
        var q = new Queue<TreeNode?>();
        q.Enqueue(this);

        while (q.Count > 0 && q.Any(x => x != null))
        {
            var count = q.Count;
            for (int i = 0; i < count; i++)
            {
                var node = q.Dequeue();
                if (node == null)
                {
                    result.Add(null);
                    q.Enqueue(null);
                    q.Enqueue(null);
                    continue;
                }
                result.Add(node.val);
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
        }

        return result;
    }
}