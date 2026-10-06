namespace Base75.Trees;

public class IsSubTree
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node?.val == subRoot?.val && IsSame(node, subRoot))
                return true;
            if (node == null)
                continue;
            queue.Enqueue(node?.left);
            queue.Enqueue(node?.right);
        }
        return false;
    }

    private bool IsSame(TreeNode? node, TreeNode? subRoot)
    {
        if (node == null && subRoot == null)
            return true;
        if (node?.val == subRoot?.val)
        {
            bool result = true;
            result &= IsSame(node?.left, subRoot?.left);
            result &= IsSame(node?.right, subRoot?.right);
            return result;
        }
        return false;
    }
}