using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00530 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t1 = new TreeNode(1);
        TreeNode t2 = new TreeNode(3);
        TreeNode t3 = new TreeNode(2);
        t1.right = t2;
        t2.left = t3;

        Debug.Log(GetMinimumDifference(t1));
    }

    //    给你一棵所有节点为非负值的二叉搜索树，请你计算树中任意两节点的差的绝对值的最小值。
    //示例：
    //输入：
    //   1
    //    \
    //     3
    //    /
    //   2
    //输出：
    //1

    public int GetMinimumDifference(TreeNode root)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode cur = root;
        List<int> res = new List<int>();
        while(s.Count > 0 || cur != null)
        {
            while(cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }
            cur = s.Pop();
            //Debug.Log(cur.val);
            res.Add(cur.val);
            cur = cur.right;
        }

        int min = int.MaxValue;
        for(int i=0; i<res.Count-1; i++)
        {
            if(res[i+1]-res[i] < min)
            {
                min = res[i + 1] - res[i];
            }
        }

        return min;
    }
}

 // Definition for a binary tree node.
  public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
 }

