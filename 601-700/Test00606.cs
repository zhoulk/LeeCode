using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00606 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TreeNode t1 = new TreeNode(1);
        TreeNode t2 = new TreeNode(2);
        TreeNode t3 = new TreeNode(3);
        TreeNode t4 = new TreeNode(4);
        t1.left = t2;
        t1.right = t3;
        t2.left = t4;
        Debug.Log(Tree2str(t1));
    }

    //    你需要采用前序遍历的方式，将一个二叉树转换成一个由括号和整数组成的字符串。
    //空节点则用一对空括号 "()" 表示。而且你需要省略所有不影响字符串与原始二叉树之间的一对一映射关系的空括号对。
    //示例 1:
    //输入: 二叉树: [1,2,3,4]
    //       1
    //     /   \
    //    2     3
    //   /    
    //  4     
    //输出: "1(2(4))(3)"
    //解释: 原本将是“1(2(4)())(3())”，
    //在你省略所有不必要的空括号对之后，
    //它将是“1(2(4))(3)”。
    //示例 2:
    //输入: 二叉树: [1,2,3,null,4]
    //       1
    //     /   \
    //    2     3
    //     \  
    //      4 
    //输出: "1(2()(4))(3)"
    //解释: 和第一个示例相似，
    //除了我们不能省略第一个对括号来中断输入和输出之间的一对一映射关系。

    public string Tree2str(TreeNode t)
    {
        if(t== null)
        {
            return "";
        }
        Stack<TreeNode> s = new Stack<TreeNode>();
        HashSet<TreeNode> visited = new HashSet<TreeNode>();
        string res = "";
        s.Push(t);
        while(s.Count > 0)
        {
            TreeNode cur = s.Peek();
            if (visited.Contains(cur))
            {
                res += ")";
                s.Pop();
            }
            else
            {
                if (cur != null)
                {
                    visited.Add(cur);
                    res += "(" + cur.val;
                    if (cur.left == null && cur.right != null)
                    {
                        res += "()";
                    }

                    if (cur.right != null)
                    {
                        s.Push(cur.right);
                    }
                    if (cur.left != null)
                    {
                        s.Push(cur.left);
                    }
                }
            }
        }
        res = res.Substring(1, res.Length - 2);

        return res;
    }
}

  public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
