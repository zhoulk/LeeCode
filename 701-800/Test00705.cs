using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00705 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyHashSet hashSet = new MyHashSet();
        hashSet.Add(1);
        hashSet.Add(2);
        Debug.Log(hashSet.Contains(1));    // 返回 true
        Debug.Log(hashSet.Contains(3));    // 返回 false (未找到)
        hashSet.Add(2);
        Debug.Log(hashSet.Contains(2));    // 返回 true
        hashSet.Remove(2);
        Debug.Log(hashSet.Contains(2));    // 返回  false (已经被删除)
    }

    //    不使用任何内建的哈希表库设计一个哈希集合
    //    具体地说，你的设计应该包含以下的功能
    //    add(value)：向哈希集合中插入一个值。
    //contains(value) ：返回哈希集合中是否存在这个值。
    //remove(value)：将给定值从哈希集合中删除。如果哈希集合中没有这个值，什么也不做。
    //示例:
    //MyHashSet hashSet = new MyHashSet();
    //    hashSet.add(1);         
    //hashSet.add(2);         
    //hashSet.contains(1);    // 返回 true
    //hashSet.contains(3);    // 返回 false (未找到)
    //hashSet.add(2);          
    //hashSet.contains(2);    // 返回 true
    //hashSet.remove(2);          
    //hashSet.contains(2);    // 返回  false (已经被删除)

    //注意：

    //所有的值都在[0, 1000000] 的范围内。
    //操作的总数目在[1, 10000] 范围内。
    //不要使用内建的哈希集合库。

}

public class MyHashSet
{
    /** Initialize your data structure here. */
    private Buket[] buketArr;
    private int buketSize = 769;
    public MyHashSet()
    {
        buketArr = new Buket[769];
        for(int i=0; i<buketSize; i++)
        {
            buketArr[i] = new Buket();
        }
    }

    public void Add(int key)
    {
        buketArr[hashCode(key)].Add(key);
    }

    public void Remove(int key)
    {
        buketArr[hashCode(key)].Remove(key);
    }

    /** Returns true if this set contains the specified element */
    public bool Contains(int key)
    {
        return buketArr[hashCode(key)].Contains(key);
    }

    int hashCode(int key)
    {
        return key % buketSize;
    }
}

class Buket
{
    private LinkedList<int> vList = new LinkedList<int>();

    public void Add(int val)
    {
        if (Contains(val))
        {
            return;
        }
        vList.AddLast(val);
    }

    public void Remove(int val)
    {
        vList.Remove(val);
    }

    public bool Contains(int val)
    {
        return vList.Find(val) != null;
    }
}
