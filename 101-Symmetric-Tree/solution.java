/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public boolean isSymmetric(TreeNode root) {
        return isSymmetric(root, root);
    }
    
    private boolean isSymmetric(TreeNode left, TreeNode right) {
        if (left == null && right == null){
            return true;
        }
        
        if (left !=null && right == null || left == null && right != null) {
            return false;
        }
        
        if (left.val == right.val){
            return isSymmetric(left.right, right.left) && isSymmetric(left.left, right.right);
        }
        
        return false;
        
        
    }
}