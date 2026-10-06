namespace Base75.Trees;

public class FindKthSmallest
{
    public int KthSmallest(TreeNode root, int k) {
        ReqFindKthSmallest(root, k, out TreeNode result);
        return result.val;
    }
    
    private int ReqFindKthSmallest(TreeNode node, int k, out TreeNode result)
    {
        int index = k;
        if (node.left != null)
        {
            index = ReqFindKthSmallest(node.left, k, out TreeNode innerResult);
            if (index == 0)
            {
                result = innerResult;
                return index;
            }
        }
        index--;
        if (index == 0)
        {
            result = node;
            return index;
        }
        
        if (node.right != null)
        {
            index = ReqFindKthSmallest(node.right, index, out TreeNode innerResult);
            if (index == 0)
            {
                result = innerResult;
                return index;
            }
        }

        result = node;
        return index;
    }
}