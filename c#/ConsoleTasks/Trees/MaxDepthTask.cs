namespace ConsoleTasks.Trees;

public class MaxDepthTask
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;
        var queue = new Queue<TreeNode>();
        var depth = 0;
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var level = queue.Count;
            for (int i = 0; i < level; i++)
            {
                var node = queue.Dequeue();
                if (node?.left != null)
                    queue.Enqueue(node.left);
                if (node?.right != null)
                    queue.Enqueue(node.right);
            }

            depth++;
        }

        return depth;
    }
}