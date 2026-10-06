namespace csharp._1028;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right; 
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) { 
        this.val = val; 
        this.left = left; 
        this.right = right; 
    }
}
public class Solution
{
    /// <summary>
    /// Beats 90% of submissions with time complexity of O(N) and space complexity of O(H)
    /// </summary>
    public TreeNode RecoverFromPreorder(string traversal)
    {
        var stack = new Stack<TreeNode>();
        int i = 0;
        int n = traversal.Length;
        while (i < n)
        {
            int depth = 0;
            
            while (i < n && traversal[i] == '-') 
            {
                depth++;
                i++;
            }
            
            int value = 0;
            while (i < n && char.IsDigit(traversal[i]))
            {
                value = value * 10 + (traversal[i] - '0');
                i++;
            }
            
            TreeNode node = new TreeNode(value);
            
            while (stack.Count > depth) 
                stack.Pop();

            if (stack.Count > 0)
            {
                TreeNode parent = stack.Peek();
                
                if (parent.left == null)
                    parent.left = node;
                else
                    parent.right = node;
            }
            stack.Push(node);
        }
        
        while (stack.Count > 1) 
            stack.Pop();

        return stack.Count == 0 ? null : stack.Peek();
    }
}