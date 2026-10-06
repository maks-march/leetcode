namespace Base75.Trees;

public class LevelOrderTravelsal
{
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        var qu = new Queue<TreeNode>();
        qu.Enqueue(root);
        while (qu.Count > 0)
        {
            var count = qu.Count;
            var l = new Stack<int>(count);
            for (int i = 0; i < count; i++)
            {
                var node = qu.Dequeue();
                if (node == null)
                    continue;
                l.Push(node.val);
                qu.Enqueue(node.right);
                qu.Enqueue(node.left);
            }
            if (l.Count > 0)
                result.Add(l.ToArray());
        }

        return result;
    }
}