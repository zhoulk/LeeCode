using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00637 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t3 = new TreeNode(3);
        TreeNode t9 = new TreeNode(9);
        TreeNode t20 = new TreeNode(20);
        TreeNode t15 = new TreeNode(15);
        TreeNode t7 = new TreeNode(7);
        TreeNode t8 = new TreeNode(8);
        TreeNode t10 = new TreeNode(10);
        t3.left = t9;
        t3.right = t20;
        t20.left = t15;
        t20.right = t7;
        t9.left = t8;
        t9.right = t10;

        IList<double> nums = AverageOfLevels(t3);
        foreach(var num in nums)
        {
            Debug.Log(num);
        }
    }

    //    给定一个非空二叉树, 返回一个由每层节点平均值组成的数组.
    //示例 1:
    //输入:
    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7
    //输出: [3, 14.5, 11]
    //    解释:
    //第0层的平均值是 3,  第1层是 14.5, 第2层是 11. 因此返回[3, 14.5, 11].
    //注意：
    //节点值的范围在32位有符号整数范围内。

    public IList<double> AverageOfLevels(TreeNode root)
    {
        List<double> ret = new List<double>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            int count = q.Count;
            double sum = 0;
            for(int i=0; i<count; i++)
            {
                TreeNode cur = q.Dequeue();
                sum += cur.val;

                Debug.Log(sum + " " + count + " " + cur.val);

                if(cur.left != null)
                {
                    q.Enqueue(cur.left);
                }
                if (cur.right != null)
                {
                    q.Enqueue(cur.right);
                }
            }
            ret.Add(sum / count);
        }
        return ret;
    }
}

  public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
