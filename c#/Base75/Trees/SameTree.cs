namespace Base75.Trees;

public class SameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q) {
        var queueP = new Queue<TreeNode>();
        var queueQ = new Queue<TreeNode>();
        queueP.Enqueue(p);
        queueQ.Enqueue(q);
        while (queueP.Count > 0 && queueQ.Count > 0)
        {
            if (queueP.Count != queueQ.Count)
                return false;
            var level = queueP.Count;
            for (int i = 0; i < level; i++)
            {
                var nodeP = queueP.Dequeue();
                var nodeQ = queueQ.Dequeue();
                if (nodeP?.val != nodeQ?.val)
                    return false;
                if (nodeP != null)
                {
                    queueP.Enqueue(nodeP.left);
                    queueP.Enqueue(nodeP.right);
                }

                if (nodeQ != null)
                {
                    queueQ.Enqueue(nodeQ.left);
                    queueQ.Enqueue(nodeQ.right);
                }
            }
        }
        return queueP.Count == queueQ.Count && queueP.Count == 0;
    }
}