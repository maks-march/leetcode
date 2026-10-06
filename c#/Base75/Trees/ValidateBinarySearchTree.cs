namespace Base75.Trees;

public class ValidateBinarySearchTree
{
    public bool IsValidBST(TreeNode root)
    {
        var stack = new Stack<(TreeNode, long, long)>();
        stack.Push((root, long.MinValue, long.MaxValue));

        while (stack.Count > 0)
        {
            var (node, min, max) = stack.Pop();
            if (node.val <= min || node.val >= max)
                return false;
            if (node.left != null)
                stack.Push((node.left, min, node.val));
            if (node.right != null)
                stack.Push((node.right, node.val, max));
        }

        return true;
    }

    private bool IsValidReq(TreeNode node, long min = long.MinValue, long max = long.MaxValue)
    {
        if (node.val <= min || node.val >= max)
            return false;
        var result = true;
        if (node.left != null)
            result &= IsValidReq(node.left, min, node.val);
        if (node.right != null && result)
            result &= IsValidReq(node.right, node.val, max);
        return result;
    }
}