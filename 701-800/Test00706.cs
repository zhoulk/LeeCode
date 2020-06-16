using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00706 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyHashMap hashMap = new MyHashMap();
        hashMap.Put(1, 1);
        hashMap.Put(2, 2);
        Debug.Log(hashMap.Get(1));            // 返回 1
        Debug.Log(hashMap.Get(3));            // 返回 -1 (未找到)
        hashMap.Put(2, 1);         // 更新已有的值
        Debug.Log(hashMap.Get(2));            // 返回 1 
        hashMap.Remove(2);         // 删除键为2的数据
        Debug.Log(hashMap.Get(2));            // 返回 -1 (未找到) 
    }

    //    不使用任何内建的哈希表库设计一个哈希映射
    //    具体地说，你的设计应该包含以下的功能
    //    put(key, value)：向哈希映射中插入(键, 值)的数值对。如果键对应的值已经存在，更新这个值。
    //get(key)：返回给定的键所对应的值，如果映射中不包含这个键，返回-1。
    //remove(key)：如果映射中存在这个键，删除这个数值对。
    //示例：
    //MyHashMap hashMap = new MyHashMap();
    //    hashMap.put(1, 1);          
    //hashMap.put(2, 2);         
    //hashMap.get(1);            // 返回 1
    //hashMap.get(3);            // 返回 -1 (未找到)
    //hashMap.put(2, 1);         // 更新已有的值
    //hashMap.get(2);            // 返回 1 
    //hashMap.remove(2);         // 删除键为2的数据
    //hashMap.get(2);            // 返回 -1 (未找到) 
    //注意：
    //所有的值都在[0, 1000000] 的范围内。
    //操作的总数目在[1, 10000] 范围内。
    //不要使用内建的哈希库。
    public class MyHashMap
    {
        /** Initialize your data structure here. */
        private Buket706[] buketArr;
        private int buketSize = 769;
        public MyHashMap()
        {
            buketArr = new Buket706[769];
            for (int i = 0; i < buketSize; i++)
            {
                buketArr[i] = new Buket706();
            }
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            buketArr[hashCode(key)].Add(new Node706(key, value));
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            Node706 node = buketArr[hashCode(key)].Get(key);
            if (node != null)
            {
                return node.value;
            }
            return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            buketArr[hashCode(key)].Remove(new Node706(key, 0));
        }

        int hashCode(int key)
        {
            return key % buketSize;
        }
    }

    class Node706
    {
        public Node706(int k, int v)
        {
            key = k;
            value = v;
        }
        public int key;
        public int value;

        public override bool Equals(object obj)
        {
            return key == ((Node706)obj).key;
        }
    }

    class Buket706
    {
        private LinkedList<Node706> vList = new LinkedList<Node706>();

        public void Add(Node706 node)
        {
            if (contain(node))
            {
                vList.Remove(node);
            }
            vList.AddLast(node);
        }

        public void Remove(Node706 node)
        {
            vList.Remove(node);
        }

        public Node706 Get(int val)
        {
            Node706 node = new Node706(val, 0);
            if (contain(node))
            {
                return vList.Find(node).Value;
            }
            return null;
        }

        bool contain(Node706 node)
        {
            return vList.Find(node) != null;
        }
    }
}
