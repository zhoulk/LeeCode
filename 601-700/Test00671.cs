using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00671 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t2 = new TreeNode(2);
        TreeNode t5 = new TreeNode(5);
        TreeNode t2_1 = new TreeNode(2);
        TreeNode t5_1 = new TreeNode(5);
        TreeNode t7 = new TreeNode(7);

        t2.left = t2_1;
        t2.right = t5;
        t5.left = t5_1;
        t5.right = t7;

        Debug.Log(FindSecondMinimumValue(t2));
    }
    //    给定一个非空特殊的二叉树，每个节点都是正数，并且每个节点的子节点数量只能为 2 或 0。
    // 如果一个节点有两个子节点的话，那么这个节点的值不大于它的子节点的值。 
    //给出这样的一个二叉树，你需要输出所有节点中的第二小的值。如果第二小的值不存在的话，输出 -1 。
    //示例 1:
    //输入: 
    //    2
    //   / \
    //  2   5
    //     / \
    //    5   7
    //输出: 5
    //说明: 最小的值是 2 ，第二小的值是 5 。
    //示例 2:
    //输入: 
    //    2
    //   / \
    //  2   2
    //输出: -1
    //说明: 最小的值是 2, 但是不存在第二小的值。

    public int FindSecondMinimumValue(TreeNode root)
    {
        long min = long.MaxValue;
        long min2 = long.MaxValue;
        Stack<TreeNode> s = new Stack<TreeNode>();
        while (s.Count > 0 || root != null)
        {
            while(root != null)
            {
                s.Push(root);
                root = root.left;
            }
            root = s.Pop();
            if(root != null)
            {
                if(root.val < min)
                {
                    min2 = min;
                    min = root.val;
                }
                else if(root.val > min)
                {
                    if(root.val < min2)
                    {
                        min2 = root.val;
                    }
                }
                root = root.right;
            }
        }
        return (int)(min2 == long.MaxValue ? -1 : min2);
    }
}
