using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00501 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t1 = new TreeNode(1);
        TreeNode t2 = new TreeNode(2);
        TreeNode t3 = new TreeNode(3);
        TreeNode t4 = new TreeNode(4);
        TreeNode t5 = new TreeNode(5);
        TreeNode t6 = new TreeNode(6);

        t1.right = t2;
        t1.left = t4;
        t2.left = t3;
        t4.left = t5;
        t4.right = t6;

        //int[] nums = FindMode(t1);
        //foreach (var s in nums)
        //{
        //    Debug.Log(s);
        //}

        nextScan(t1);
    }

    //    给定一个有相同值的二叉搜索树（BST），找出 BST 中的所有众数（出现频率最高的元素）。

    //假定 BST 有如下定义：

    //结点左子树中所含结点的值小于等于当前结点的值
    //结点右子树中所含结点的值大于等于当前结点的值
    //左子树和右子树都是二叉搜索树
    //例如：
    //给定 BST[1, null, 2, 2],

    //   1
    //    \
    //     2
    //    /
    //   2
    //返回[2].

    //提示：如果众数超过1个，不需考虑输出顺序

    //进阶：你可以不使用额外的空间吗？（假设由递归产生的隐式调用栈的开销不被计算在内）

    public int[] FindMode(TreeNode root)
    {
        Dictionary<int, int> numDic = new Dictionary<int, int>();
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode cur = root;
        int max = 0;
        while (s.Count > 0 || cur != null)
        {
            while (cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }

            cur = s.Pop();
            //Debug.Log(cur.val);
            if (numDic.ContainsKey(cur.val))
            {
                numDic[cur.val]++;
            }
            else
            {
                numDic.Add(cur.val, 1);
            }
            if (numDic[cur.val] > max)
            {
                max = numDic[cur.val];
            }
            cur = cur.right;
        }

        List<int> res = new List<int>();
        foreach (var kv in numDic)
        {
            if(kv.Value == max)
            {
                res.Add(kv.Key);
            }
        }

        return res.ToArray();
    }

    void preScan(TreeNode root)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);
        TreeNode cur;
        while(s.Count > 0)
        {
            cur = s.Pop();
            Debug.Log(cur.val);
            if(cur.right != null)
            {
                s.Push(cur.right);
            }
            if (cur.left != null)
            {
                s.Push(cur.left);
            }
        }
    }

    void midScan(TreeNode root)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode cur = root;
        while (s.Count > 0 || cur != null)
        {
            while(cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }

            cur = s.Pop();
            if (cur != null)
            {
                Debug.Log(cur.val);
            }
            cur = cur.right;
        }
    }

    void nextScan(TreeNode root)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode cur = root;
        TreeNode pre = null;
        while (s.Count > 0 || cur != null)
        {
            while (cur != null)
            {
                s.Push(cur);
                cur = cur.left;
            }

            cur = s.Peek();
            if (cur.right == null || cur.right == pre)
            {
                s.Pop();
                Debug.Log(cur.val);
                pre = cur;
                cur = null;
            }
            else
            {
                cur = cur.right;
            }
        }
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
