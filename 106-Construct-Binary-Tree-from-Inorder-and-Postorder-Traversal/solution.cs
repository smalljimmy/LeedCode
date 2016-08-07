/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    
    /**
    in-order:   4 2 5  (1)  6 7 3 8
    post-order: 4 5 2  6 7 8 3  (1)
    
    
    **/
    
    
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        int instart = 0;
        int inend = inorder.Length-1;
        
        int poststart = 0;
        int postend = postorder.Length-1;
        
        return buildTree(inorder, instart, inend, postorder, poststart, postend);
        
    }
    
    
    public TreeNode buildTree(int[] inorder, int instart, int inend, int[] postorder, int poststart, int postend) {
        if (instart > inend || poststart > postend){
            return null;
        }
        
        TreeNode root = new TreeNode(postorder[postend]);
        
        int k = instart;
        for (k = instart; k <= inend; k++){
            if (inorder[k] == postorder[postend]){
                break;
            }
        }
        
        root.left = buildTree(inorder, instart, k-1, postorder, poststart, poststart + k - 1 - instart );
        root.right = buildTree(inorder, k+1, inend, postorder, poststart + k - instart, postend -1);
        
        return root;
    }
    
}