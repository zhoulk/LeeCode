using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00653 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t2 = new TreeNode(2);
        TreeNode t1 = new TreeNode(1);
        TreeNode t3 = new TreeNode(3);
        t2.left = t1;
        t2.right = t3;
        Debug.Log(FindTarget(t2,4));
    }

    //    给定一个二叉搜索树和一个目标结果，如果 BST 中存在两个元素且它们的和等于给定的目标结果，则返回 true。
    //案例 1:
    //输入: 
    //    5
    //   / \
    //  3   6
    // / \   \
    //2   4   7
    //Target = 9
    //输出: True
    //案例 2:
    //输入: 
    //    5
    //   / \
    //  3   6
    // / \   \
    //2   4   7
    //Target = 28
    //输出: False

    public bool FindTarget(TreeNode root, int k)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        List<int> res = new List<int>();
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
                res.Add(root.val);
                //Debug.Log(root.val);
                root = root.right;
            }
        }
        int i = 0;
        int j = res.Count - 1;
        while (i < j)
        {
            if(res[i] + res[j] == k)
            {
                return true;
            }else if (res[i] + res[j] > k)
            {
                j--;
            }
            else
            {
                i++;
            }
        }
        return false;
    }
}
