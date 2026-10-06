namespace Base75.Graphs;

public class GraphClone
{
    public Node CloneGraph(Node node) {
        var hs = new Dictionary<int, Node>();
        
        Node Dfs(Node source)
        {
            if (source == null)
                return null;
            var clone = new Node(source.val);
            hs[clone.val] = clone;
            foreach (var neighbor in source.neighbors)
            {
                if (!hs.ContainsKey(neighbor.val))
                    clone.neighbors.Add(Dfs(neighbor));
                else
                    clone.neighbors.Add(hs[neighbor.val]);
            }
            return clone;
        }
        
        return Dfs(node);
    }
    
    public Node CloneGraphFast(Node node) {
        if (node == null) return null;
        var oldToNew = new Dictionary<Node, Node>();
        var q = new Queue<Node>();
        oldToNew[node] = new Node(node.val);
        q.Enqueue(node);

        while (q.Count > 0) {
            var cur = q.Dequeue();
            foreach (var nei in cur.neighbors) {
                if (!oldToNew.ContainsKey(nei)) {
                    oldToNew[nei] = new Node(nei.val);
                    q.Enqueue(nei);
                }
                oldToNew[cur].neighbors.Add(oldToNew[nei]);
            }
        }
        return oldToNew[node];
    }
}