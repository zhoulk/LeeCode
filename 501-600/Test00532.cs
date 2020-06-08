using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00532 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindPairs(new int[] { 1,2,3,4,5 }, 1));
    }

    //    给定一个整数数组和一个整数 k, 你需要在数组里找到不同的k-diff 数对。
    //  这里将 k-diff 数对定义为一个整数对(i, j), 其中 i 和 j 都是数组中的数字，且两数之差的绝对值是 k.
    //      示例 1:
    //输入: [3, 1, 4, 1, 5], k = 2
    //      输出: 2
    //解释: 数组中有两个 2-diff 数对, (1, 3) 和(3, 5)。
    //尽管数组中有两个1，但我们只应返回不同的数对的数量。
    //示例 2:
    //输入:[1, 2, 3, 4, 5], k = 1
    //输出: 4
    //解释: 数组中有四个 1-diff 数对, (1, 2), (2, 3), (3, 4) 和(4, 5)。
    //示例 3:
    //输入: [1, 3, 1, 5, 4], k = 0
    //输出: 1
    //解释: 数组中只有一个 0-diff 数对，(1, 1)。
    //注意:
    //数对(i, j) 和数对(j, i) 被算作同一数对。
    //数组的长度不超过10,000。
    //所有输入的整数的范围在[-1e7, 1e7]。

    public int FindPairs(int[] nums, int k)
    {
        //HashSet<string> res = new HashSet<string>();
        int n = 0;
        int pre =int.MinValue;
        Array.Sort(nums);

        if (k == 0)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i+1] && pre != nums[i])
                {
                    n++;
                    pre = nums[i];
                }
            }
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (pre == nums[i])
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] - nums[i] == k)
                    {
                        //res.Add(nums[i] + "-" + nums[j]);
                        //Debug.Log(nums[i] + "-" + nums[j]);
                        n++;
                        pre = nums[i];
                        break;
                    }
                }
            }
        }
        
        return n;
    }
}
