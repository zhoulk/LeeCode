using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00437 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t1 = new TreeNode(5);
        TreeNode t2 = new TreeNode(4);
        TreeNode t3 = new TreeNode(8);
        TreeNode t4 = new TreeNode(11);
        TreeNode t5 = new TreeNode(13);
        TreeNode t6 = new TreeNode(4);
        TreeNode t7 = new TreeNode(7);
        TreeNode t8 = new TreeNode(2);
        TreeNode t9 = new TreeNode(5);
        TreeNode t10 = new TreeNode(1);

        t1.left = t2;
        t1.right = t3;
        t2.left = t4;
        t3.left = t5;
        t3.right = t6;
        t4.left = t7;
        t4.right = t8;
        t6.left = t9;
        t6.right = t10;
        Debug.Log(PathSum(t1, 22));
    }

    //给定一个二叉树，它的每个结点都存放着一个整数值。

    //找出路径和等于给定数值的路径总数。

    //路径不需要从根节点开始，也不需要在叶子节点结束，但是路径方向必须是向下的（只能从父节点到子节点）。

    //二叉树不超过1000个节点，且节点数值范围是[-1000000, 1000000] 的整数。

    //示例：

    //root = [10,5,-3,3,2,null,11,3,-2,null,1], sum = 8

    //      10
    //     /  \
    //    5   -3
    //   / \    \
    //  3   2   11
    // / \   \
    //3  -2   1

    //返回 3。和等于 8 的路径有:

    //1.  5 -> 3
    //2.  5 -> 2 -> 1
    //3.  -3 -> 11

    public int PathSum(TreeNode root, int sum)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode temp = root;
        int cnt = 0;
        while (temp != null || s.Count > 0)
        {
            if (temp != null)
            {
                s.Push(temp);
                temp = temp.left;
            }
            else
            {
                temp = s.Pop();
                cnt += hasPath(temp, sum);
                temp = temp.right;
            }
        }
        return cnt;
    }

    // 后序遍历
    int hasPath(TreeNode root, int sum)
    {
        int cnt = 0;

        //Debug.Log("cal " + root.val);

        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode temp = root;
        TreeNode r_temp = null;
        int _s = 0;
        while (temp != null || s.Count > 0)
        {
            if(temp != null)
            {
                s.Push(temp);
                _s += temp.val;
                //Debug.Log("_s = " + _s + " val=" + temp.val);
                if (_s == sum)
                {
                    cnt++;
                }
                temp = temp.left;
            }
            else
            {
                temp = s.Peek();
                if (temp.right != null && temp.right != r_temp)
                {
                    temp = temp.right;
                }
                else
                {
                    TreeNode tt = s.Pop();
                    _s -= tt.val;
                    //Debug.Log("_s = " + _s + " --- val=" + tt.val);
                    r_temp = temp;
                    temp = null;
                }
            }
        }
        return cnt;
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

