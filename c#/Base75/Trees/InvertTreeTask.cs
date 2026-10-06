namespace Base75.Trees;

public class InvertTreeTask
{
    public TreeNode InvertTree(TreeNode root)
    {
        Swap(root);
        return root;
    }

    public void Swap(TreeNode node)
    {
        if (node != null)
            (node.left, node.right) = (node.right, node.left);
        if (node?.left != null)
            Swap(node.left);
        if (node?.right != null)
            Swap(node.right);
    }
}