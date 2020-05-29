using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00538 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t1 = new TreeNode(5);
        TreeNode t2 = new TreeNode(2);
        TreeNode t3 = new TreeNode(13);
        t1.right = t3;
        t1.left = t2;

        ConvertBST(t1);
    }

    //    给定一个二叉搜索树（Binary Search Tree），把它转换成为累加树（Greater Tree)，
    // 使得每个节点的值是原来的节点值加上所有大于它的节点值之和。
    //例如：
    //输入: 原始二叉搜索树:
    //              5
    //            /   \
    //           2     13
    //输出: 转换为累加树:
    //             18
    //            /   \
    //          20     13

    public TreeNode ConvertBST(TreeNode root)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode cur = root;
        int sum = 0;
        while(s.Count > 0 || cur != null)
        {
            while (cur != null)
            {
                s.Push(cur);
                cur = cur.right;
            }

            cur = s.Pop();
            cur.val += sum;
            sum = cur.val;
            Debug.Log(cur.val);
            cur = cur.left;
        }

        return root;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}
