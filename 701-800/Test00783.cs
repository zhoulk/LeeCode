using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00783 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t4 = new TreeNode(4);
        TreeNode t2 = new TreeNode(2);
        TreeNode t1 = new TreeNode(1);
        TreeNode t3 = new TreeNode(3);
        TreeNode t6 = new TreeNode(6);

        t4.left = t2;
        t4.right = t6;
        t2.left = t1;
        t2.right = t3;

        Debug.Log(MinDiffInBST(t4));
    }

    //    给定一个二叉搜索树的根节点 root，返回树中任意两节点的差的最小值。
    //示例：
    //输入: root = [4,2,6,1,3,null,null]
    //    输出: 1
    //解释:
    //注意，root是树节点对象(TreeNode object)，而不是数组。
    //给定的树[4, 2, 6, 1, 3, null, null] 可表示为下图:
    //          4
    //        /   \
    //      2      6
    //     / \    
    //    1   3  
    //最小的差值是 1, 它是节点1和节点2的差值, 也是节点3和节点2的差值。
    //注意：
    //二叉树的大小范围在 2 到 100。
    //二叉树总是有效的，每个节点的值都是整数，且不重复。
    //本题与 530：https://leetcode-cn.com/problems/minimum-absolute-difference-in-bst/ 相同
    public int MinDiffInBST(TreeNode root)
    {
        int min = int.MaxValue;
        int pre = int.MinValue;
        Stack<TreeNode> s = new Stack<TreeNode>();
        while(s.Count > 0 || root != null)
        {
            while(root != null)
            {
                s.Push(root);
                root = root.left;
            }

            TreeNode cur = s.Pop();
            if(cur != null)
            {
                if(pre == int.MinValue)
                {
                    pre = cur.val;
                }
                else
                {
                    min = Math.Min(cur.val - pre, min);
                    pre = cur.val;
                }
                //Debug.Log(cur.val);
                root = cur.right;
            }
        }
        return min;
    }
}

 public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
 }
