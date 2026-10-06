using System.Text;

namespace Base75.Trees;

public class SerializeAndDeserialzieTree
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        var sb = new StringBuilder();
        
        void dfs(TreeNode node)
        {
            if (node == null)
            {
                sb.Append('n');
                sb.Append(',');
                return;
            }
            sb.Append(node.val);
            sb.Append(',');
            dfs(node.left);
            dfs(node.right);
        }
        
        dfs(root);
        return sb.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        var parsed = data.Split(',');
        var i = 0;

        TreeNode dfs()
        {
            if (parsed[i] == "n")
            {
                i++;
                return null;
            }
            var node = new TreeNode(int.Parse(parsed[i]));
            i++;
            node.left = dfs();
            node.right = dfs();
            return node;
        }
        
        return dfs();
    }
}