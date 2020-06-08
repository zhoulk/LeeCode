using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00669 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t0 = new TreeNode(0);
        TreeNode t1 = new TreeNode(1);
        TreeNode t2 = new TreeNode(2);
        TreeNode t3 = new TreeNode(3);
        TreeNode t4 = new TreeNode(4);

        t3.left = t0;
        t3.right = t4;
        t0.right = t2;
        t2.left = t1;
        Debug.Log(TrimBST(t3, 1, 3));
    }

    //    给定一个二叉搜索树，同时给定最小边界L 和最大边界R。通过修剪二叉搜索树，使得所有节点的值在[L, R] 中(R>=L) 。
    // 你可能需要改变树的根节点，所以结果应当返回修剪好的二叉搜索树的新的根节点。
    //示例 1:
    //输入: 
    //    1
    //   / \
    //  0   2
    //  L = 1
    //  R = 2
    //输出: 
    //    1
    //      \
    //       2
    //示例 2:
    //输入: 
    //    3
    //   / \
    //  0   4
    //   \
    //    2
    //   /
    //  1
    //  L = 1
    //  R = 3
    //输出: 
    //      3
    //     / 
    //   2   
    //  /
    // 1

    public TreeNode TrimBST(TreeNode root, int L, int R)
    {
        if(root == null)
        {
            return null;
        }

        if (root.val < L)
            return TrimBST(root.right, L, R);
        if (root.val > R)
            return TrimBST(root.left, L, R);

        root.left = TrimBST(root.left, L, R);
        root.right = TrimBST(root.right, L, R);
        return root;
    }

    void display(TreeNode root)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode cur = root;
        while (s.Count > 0 || cur != null)
        {
            while (cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }
            cur = s.Pop();
            if (cur != null)
            {
                Debug.Log(cur.val);
                cur = cur.right;
            }
        }
    }
}

public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
}
