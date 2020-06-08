using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00643 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindMaxAverage(new int[] { 0,4,0,3,2 }, 1));
    }

    //    给定 n 个整数，找出平均数最大且长度为 k 的连续子数组，并输出该最大平均数。
    //示例 1:
    //输入: [1,12,-5,-6,50,3], k = 4
    //输出: 12.75
    //解释: 最大平均数(12-5-6+50)/4 = 51/4 = 12.75
    //注意:
    //1 <= k <= n <= 30,000。
    //所给数据范围[-10, 000，10, 000]。

    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;

        for (int j = 0; j < k; j++)
        {
            sum += nums[j];
        }

        double max = sum;
        for (int i=k; i<nums.Length; i++)
        {
            sum = sum + nums[i] - nums[i - k];
            max = Math.Max(max, sum);
        }
        return max / k;
    }
}
