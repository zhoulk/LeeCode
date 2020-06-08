using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00687 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t5 = new TreeNode(5);
        TreeNode t5_1 = new TreeNode(5);
        TreeNode t5_2 = new TreeNode(5);
        TreeNode t4 = new TreeNode(4);
        TreeNode t1 = new TreeNode(1);
        TreeNode t1_1 = new TreeNode(1);
        t5.left = t4;
        t5.right = t5_1;
        t4.left = t1;
        t4.right = t1_1;
        t5_1.right = t5_2;
        Debug.Log(LongestUnivaluePath(t5));
    }

    //    给定一个二叉树，找到最长的路径，这个路径中的每个节点具有相同值。 这条路径可以经过也可以不经过根节点。
    //注意：两个节点之间的路径长度由它们之间的边数表示。
    //示例 1:
    //输入:
    //              5
    //             / \
    //            4   5
    //           / \   \
    //          1   1   5
    //输出:
    //2
    //示例 2:
    //输入:
    //              1
    //             / \
    //            4   5
    //           / \   \
    //          4   4   5
    //输出:
    //2
    //注意: 给定的二叉树不超过10000个结点。 树的高度不超过1000。

    int ans = 0;
    public int LongestUnivaluePath(TreeNode root)
    {
        ArrowLength(root);
        return ans;
    }

    int ArrowLength(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        int left = ArrowLength(root.left);
        int right = ArrowLength(root.right);
        int arrowLeft = 0, arrowRight = 0;
        if(root.left != null && root.left.val == root.val)
        {
            arrowLeft = left + 1;
        }
        if (root.right != null && root.right.val == root.val)
        {
            arrowRight = right + 1;
        }
        ans = Math.Max(ans, arrowLeft + arrowRight);
        return Math.Max(arrowLeft, arrowRight);
    }
}
