using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00697 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindShortestSubArray(new int[] { 0 }));
    }

    //    给定一个非空且只包含非负数的整数数组 nums, 数组的度的定义是指数组里任一元素出现频数的最大值。
    //你的任务是找到与 nums拥有相同大小的度的最短连续子数组，返回其长度。
    //示例 1:
    //输入: [1, 2, 2, 3, 1]
    //    输出: 2
    //解释: 
    //输入数组的度是2，因为元素1和2的出现频数最大，均为2.
    //连续子数组里面拥有相同度的有如下所示:
    //[1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
    //    最短连续子数组[2, 2] 的长度为2，所以返回2.
    //     示例 2:
    //输入: [1,2,2,3,1,4,2]
    //    输出: 6
    //注意:
    //nums.length 在1到50,000区间范围内。
    //nums[i] 是一个在0到49,999范围内的整数。

    public int FindShortestSubArray(int[] nums)
    {
        Dictionary<int, int> left = new Dictionary<int, int>();
        Dictionary<int, int> right = new Dictionary<int, int>();
        Dictionary<int, int> count = new Dictionary<int, int>();
        int maxCnt = 0;
        int maxValue = 0;
        int res = int.MaxValue;
        for (int i=0; i<nums.Length; i++)
        {
            int x = nums[i];
            if (left.ContainsKey(x))
            {
                left[x] = Math.Min(left[x], i);
            }
            else
            {
                left.Add(x, i);
            }

            if (right.ContainsKey(x))
            {
                right[x] = Math.Max(right[x], i);
            }
            else
            {
                right.Add(x, i);
            }
            if (count.ContainsKey(x))
            {
                count[x] = count[x] +1;
            }
            else
            {
                count.Add(x, 1);
            }
            if(count[x] > maxCnt)
            {
                maxCnt = count[x];
                maxValue = x;
            }
        }
        foreach (var kv in count)
        {
            if(kv.Value == maxCnt)
            {
                res = Math.Min(res, right[kv.Key] - left[kv.Key] + 1);
            }
        }
        return res;
    }
}
