using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00617 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t1 = new TreeNode(1);
        TreeNode t2 = new TreeNode(2);
        TreeNode t3 = new TreeNode(3);
        TreeNode t4 = new TreeNode(4);
        TreeNode t5 = new TreeNode(5);

        t1.left = t3;
        t1.right = t2;
        t3.left = t5;

        TreeNode tt1 = new TreeNode(1);
        TreeNode tt2 = new TreeNode(2);
        TreeNode tt3 = new TreeNode(3);
        TreeNode tt4 = new TreeNode(4);
        TreeNode tt7 = new TreeNode(7);

        tt2.left = tt1;
        tt1.right = tt4;
        tt2.right = tt3;
        tt3.right = tt7;

        Debug.Log(MergeTrees(t1, tt2));
    }

    //    给定两个二叉树，想象当你将它们中的一个覆盖到另一个上时，两个二叉树的一些节点便会重叠。
    // 你需要将他们合并为一个新的二叉树。合并的规则是如果两个节点重叠，那么将他们的值相加作为节点合并后的新值，
    // 否则不为 NULL 的节点将直接作为新二叉树的节点。
    //示例 1:
    //输入: 
    //	Tree 1                     Tree 2                  
    //          1                         2                             
    //         / \                       / \                            
    //        3   2                     1   3                        
    //       /                           \   \                      
    //      5                             4   7                  
    //输出: 
    //合并后的树:
    //	     3
    //	    / \
    //	   4   5
    //	  / \   \ 
    //	 5   4   7
    //注意: 合并必须从两个树的根节点开始。
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
    {
        if(t1 == null)
        {
            return t2;
        }
        Stack<TreeNode[]> s = new Stack<TreeNode[]>();
        s.Push(new TreeNode[] { t1, t2});
        while (s.Count > 0)
        {
            TreeNode[] cur = s.Pop();
            if (cur[0] == null || cur[1] == null)
            {
                continue;
            }
            cur[0].val += cur[1].val;
            if(cur[0].left == null)
            {
                cur[0].left = cur[1].left;
            }
            else
            {
                s.Push(new TreeNode[] { cur[0].left, cur[1].left });
            }

            if (cur[0].right == null)
            {
                cur[0].right = cur[1].right;
            }
            else
            {
                s.Push(new TreeNode[] { cur[0].right, cur[1].right });
            }
        }
        return t1;
    }
}
