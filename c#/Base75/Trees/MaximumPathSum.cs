namespace Base75.Trees;

public class MaximumPathSum
{
    private int _maxSum = int.MinValue;
    
    public int MaxPathSum(TreeNode root)
    {
        MaxPathSumReq(root);
        return _maxSum;
    }
    
    public int MaxPathSumReq(TreeNode root)
    {
        if (root == null)
            return 0;
        if (root.left == null && root.right == null)
        {
            _maxSum = Math.Max(root.val, _maxSum);
            return root.val;
        }
        var left = MaxPathSumReq(root.left);
        var right = MaxPathSumReq(root.right);
        var maxSub = Math.Max(left, right);
        var max = int.MinValue;
        max = Math.Max(max, maxSub + root.val);
        max = Math.Max(max, root.val);
        _maxSum = Math.Max(max, _maxSum);
        _maxSum = Math.Max(left + right + root.val, _maxSum);
        return max;
    }
}