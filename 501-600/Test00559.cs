using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00559 : MonoBehaviour
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

        n1.children = new List<Node> { n2, n3, n4};
        n2.children = new List<Node> { n5, n6};

        Debug.Log(MaxDepth(n1));
    }

    //    给定一个 N 叉树，找到其最大深度。

    //最大深度是指从根节点到最远叶子节点的最长路径上的节点总数。

    //例如，给定一个 3叉树 :







    //我们应返回其最大深度，3。

    //说明:

    //树的深度不会超过 1000。
    //树的节点总不会超过 5000。
    //public int MaxDepth(Node root)
    //{
    //    if(root == null)
    //    {
    //        return 0;
    //    }
    //    int max = 0;
    //    if(root.children != null)
    //    {
    //        foreach(Node n in root.children)
    //        {
    //            max = Math.Max(max, MaxDepth(n));
    //        }
    //    }
    //    return max + 1;
    //}

    public int MaxDepth(Node root)
    {
        Stack<Node> s = new Stack<Node>();
        s.Push(root);
        while (s.Count > 0)
        {
            Node cur = s.Pop();
            if (cur != null)
            {
                Debug.Log(cur.val);
                if(cur.children != null)
                {
                    foreach(var n in cur.children)
                    {
                        s.Push(n);
                    }
                }
            }
        }

        return 0;
    }
}

//Definition for a Node.
public class Node
{
    public int val;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}

