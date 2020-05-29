using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00543 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t1 = new TreeNode(1);
        TreeNode t2 = new TreeNode(2);
        TreeNode t3 = new TreeNode(3);
        TreeNode t4 = new TreeNode(4);
        TreeNode t5 = new TreeNode(5);

        t1.left = t2;
        t1.right = t3;
        t2.left = t4;
        t2.right = t5;

        Debug.Log(DiameterOfBinaryTree(t1));
    }

    //    给定一棵二叉树，你需要计算它的直径长度。
    // 一棵二叉树的直径长度是任意两个结点路径长度中的最大值。这条路径可能穿过也可能不穿过根结点。
    //示例 :
    //给定二叉树
    //          1
    //         / \
    //        2   3
    //       / \     
    //      4   5    
    //返回 3, 它的长度是路径[4, 2, 1, 3] 或者[5, 2, 1, 3]。
    //注意：两结点之间的路径长度是以它们之间边的数目表示。
    int ans = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        ans = 1;
        depth(root);
        return ans-1;
    }

    int depth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int L = depth(root.left);
        int R = depth(root.right);
        ans = Math.Max(ans, L + R + 1);
        return Math.Max(L, R) + 1;
    }
}
