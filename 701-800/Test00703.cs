using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00703 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        KthLargest obj = new KthLargest(3, new int[] {4,5,8,2});
        Debug.Log(obj.Add(3));
        Debug.Log(obj.Add(5));
        Debug.Log(obj.Add(10));
        Debug.Log(obj.Add(9));
        Debug.Log(obj.Add(4));
    }

    //    设计一个找到数据流中第K大元素的类（class）。注意是排序后的第K大元素，不是第K个不同的元素。
    //你的 KthLargest类需要一个同时接收整数 k 和整数数组nums 的构造器，它包含数据流中的初始元素。
    //每次调用 KthLargest.add，返回当前数据流中第K大的元素。
    //   示例:
    //   int k = 3;
    //    int[] arr = [4, 5, 8, 2];
    //    KthLargest kthLargest = new KthLargest(3, arr);
    //    kthLargest.add(3);   // returns 4
    //kthLargest.add(5);   // returns 5
    //kthLargest.add(10);  // returns 5
    //kthLargest.add(9);   // returns 8
    //kthLargest.add(4);   // returns 8
    //说明:
    //你可以假设 nums的长度≥ k-1 且k ≥ 1。

}

public class KthLargest
{
    int[] heap;
    public KthLargest(int k, int[] nums)
    {
        heap = new int[k];
        for (int i = 0; i < k; i++)
        {
            heap[i] = int.MinValue;
        }
        for (int i=0; i<nums.Length; i++)
        {
            Add(nums[i]);
        }
    }

    public int Add(int val)
    {
        if(val > heap[0])
        {
            heap[0] = val;
            adjustHeap();
        }
        return heap[0];
    }

    void adjustHeap()
    {
        int parent = 0;
        int tmp = heap[parent];
        while (parent * 2 < heap.Length)
        {
            int child = parent * 2+1;
            if(child < heap.Length && child +1 < heap.Length && heap[child] > heap[child + 1])
            {
                child++;
            }
            if(child < heap.Length && heap[child] < tmp)
            {
                heap[parent] = heap[child];
                parent = child;
            }
            else
            {
                break;
            }
        }
        heap[parent] = tmp;
    }
}

//public class KthLargest
//{
//    int [] orderNums;
//    public KthLargest(int k, int[] nums)
//    {
//        Array.Sort(nums);
//        orderNums = new int[k];
//        for (int i = nums.Length - 1; i >= 0 && k>0; i--)
//        {
//            orderNums[k - 1] = nums[i];
//            k--;
//        }
//        for (int i = 0; i <k; i++)
//        {
//            orderNums[i] = int.MinValue;
//        }
//    }

//    public int Add(int val)
//    {
//        for (int i = orderNums.Length - 1; i >= 0; i--)
//        {
//            if (orderNums[i] < val)
//            {
//                int temp = orderNums[i];
//                orderNums[i] = val;
//                val = temp;
//            }
//        }

//        return orderNums[0];
//    }
//}
