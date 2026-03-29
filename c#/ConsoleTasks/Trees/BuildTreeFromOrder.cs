namespace ConsoleTasks.Trees;

public class BuildTreeFromOrder
{
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0 ||  inorder.Length == 0) 
            return null;

        var root = new TreeNode(preorder[0]);
        var mid = Array.IndexOf(inorder, preorder[0]);
        root.left = BuildTree(preorder[1..(mid+1)], inorder[..mid]);
        root.right = BuildTree(preorder[(mid+1)..], inorder[(mid+1)..]);
        return root;
    }
}