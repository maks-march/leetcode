namespace ConsoleTasks.Trees;

public class LowestCommonAncestorTask
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        var current = root;
        while (current != null)
        {
            if (p.val == current.val || q.val == current.val)
                return current;
            if (q.val <= current.val && p.val <= current.val)
            {
                current = current.left;
            } else if (q.val >= current.val && p.val >= current.val)
            {
                current = current.right;
            }
            else
            {
                return current;
            }
        }

        return root;
    }
}