using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00563 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t1 = new TreeNode(1);
        TreeNode t2 = new TreeNode(2);
        TreeNode t3 = new TreeNode(3);
        t1.right = t3;
        t1.left = t2;

        Debug.Log(FindTilt(t1));
    }

    //    给定一个二叉树，计算整个树的坡度。
    //一个树的节点的坡度定义即为，该节点左子树的结点之和和右子树结点之和的差的绝对值。空结点的的坡度是0。
    //整个树的坡度就是其所有节点的坡度之和。
    //示例:
    //输入: 
    //         1
    //       /   \
    //      2     3
    //输出: 1
    //解释: 
    //结点的坡度 2 : 0
    //结点的坡度 3 : 0
    //结点的坡度 1 : |2-3| = 1
    //树的坡度 : 0 + 0 + 1 = 1
    //注意:
    //任何子树的结点的和不会超过32位整数的范围。
    //坡度的值不会超过32位整数的范围。

    public int FindTilt(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        int l = FindTilt(root.left);
        int r = FindTilt(root.right);
        return l + r + Math.Abs(sum(root.left) - sum(root.right));
    }

    public int sum(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        return sum(root.left) + sum(root.right) + root.val;
    }
}
