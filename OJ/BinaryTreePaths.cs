using System;
using System.Collections.Generic;
public class TreeNode {
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int x) { val = x; }
}
 
public class Solution {
    public static IList<string> BinaryTreePaths(TreeNode root) {
    	List<string> left = new List<string>();
    	List<string> right = new List<string>();
    	List<string> result = new List<string>();
//    	Console.WriteLine("break");

	if(root == null)
		return result;

    	if(root.left==null && root.right == null)//HasValue值才有
    	{
    		result.Add(root.val.ToString());
    		return result;
    	}
    	if(root.left != null)
    	{
    		left = (List<string>)BinaryTreePaths(root.left);
    		for (int i =0; i<left.Count ; i++)
			{
				left[i] = left[i].Insert(0, root.val.ToString()+"->");
			}
/*    		 foreach(string s in left)
    		 {
    		 	s = s.Insert(0, root.val.ToString()+"->");
    		 }
*/
    	}

    	if(root.right != null)
    	{
    		right = (List<string>)BinaryTreePaths(root.right);
			
			for (int i =0; i<right.Count ; i++)
			{
				right[i] = right[i].Insert(0, root.val.ToString()+"->");
			}
/*    		foreach(string s in right)
    		 {
    		 	s = s.Insert(0, root.val.ToString()+"->");
    		 }
*/
    	}

    	left.AddRange(right);
    	return left;
    }

    public static void Main()
    {
    	TreeNode root = new TreeNode(1);
    	root.left = new TreeNode(2);
    	root.right = new TreeNode(3);
    	root.left.right = new TreeNode(5);

    	IList<string> result = new List<string>();
    	result = Solution.BinaryTreePaths(root);

    	foreach (string s in result)
    	{
    		Console.WriteLine(s);
    	}

    }
}