using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00590 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Node n1 = new Node(1);
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);
        Node n5 = new Node(5);
        Node n6 = new Node(6);

        n1.children = new List<Node> { n2, n3, n4 };
        n2.children = new List<Node> { n5, n6 };

        Debug.Log(Postorder(n1));
    }

    //    给定一个 N 叉树，返回其节点值的后序遍历。

    //例如，给定一个 3叉树 :







    //返回其后序遍历: [5,6,3,2,4,1].



    //说明: 递归法很简单，你可以使用迭代法完成此题吗?
    //public IList<int> Postorder(Node root)
    //{
    //    List<int> res = new List<int>();
    //    Stack<Node> s = new Stack<Node>();
    //    s.Push(root);
    //    while(s.Count > 0)
    //    {
    //        Node cur = s.Pop();
    //        if(cur != null)
    //        {
    //            res.Insert(0,cur.val);
    //            //Debug.Log(cur.val);
    //            if(cur.children != null)
    //            {
    //                foreach(var n in cur.children)
    //                {
    //                    s.Push(n);
    //                }
    //            }
    //        }
    //    }
    //    return res;
    //}
    public IList<int> Postorder(Node root)
    {
        List<int> res = new List<int>();
        HashSet<Node> h = new HashSet<Node>();
        Stack<Node> s = new Stack<Node>();
        while (s.Count > 0 || root != null)
        {
            if(root == null)
            {
                root = s.Pop();
            }

            if (h.Contains(root))
            {
                Debug.Log(root.val);
            }
            else
            {
                h.Add(root);
                s.Push(root);
                if (root.children != null)
                {
                    for (int i = root.children.Count - 1; i >= 0; i--)
                    {
                        s.Push(root.children[i]);
                    }
                }
            }
            root = null;
        }
        return res;
    }
}
