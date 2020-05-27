using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00453 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MinMoves(new int[] {1, 2, 3 }));
    }

    //    给定一个长度为 n 的非空整数数组，找到让数组所有元素相等的最小移动次数。每次移动将会使 n - 1 个元素增加 1。

    //示例:

    //输入:
    //[1,2,3]

    //    输出:
    //3

    //解释:
    //只需要3次移动（注意每次移动会增加两个元素的值）：

    //[1,2,3]  =>  [2,3,3]  =>  [3,4,3]  =>  [4,4,4]

    //public int MinMoves(int[] nums)
    //{
    //    int cnt = 0;
    //    while (true)
    //    {
    //        int maxIndex = -1;
    //        int minIndex = -1;
    //        int min = int.MinValue;
    //        int max = int.MaxValue;
    //        for (int x = 0; x < nums.Length; x++)
    //        {
    //            if (nums[x] >= min)
    //            {
    //                min = nums[x];
    //                maxIndex = x;
    //            }
    //            if (nums[x] <= max)
    //            {
    //                max = nums[x];
    //                minIndex = x;
    //            }
    //        }

    //        int offset = nums[maxIndex] - nums[minIndex];

    //        if (offset == 0)
    //        {
    //            break;
    //        }
    //        else
    //        {
    //            for (int x = 0; x < nums.Length; x++)
    //            {
    //                if(x != maxIndex)
    //                {
    //                    nums[x] += offset;
    //                }
    //            }
    //            cnt += offset;
    //        }
    //    }

    //    return cnt;
    //}

    public int MinMoves(int[] nums)
    {
        List<int> list = new List<int>();
        list.AddRange(nums);
        list.Sort();

        int cnt = 0;
        for(int i= list.Count - 1; i>0; i--)
        {
            cnt += list[i] - list[0];
        }

        return cnt;
    }
}
