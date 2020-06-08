using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00594 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindLHS(new int[] { 1, 3, 2, 2, 5, 2, 3, 7 }));
    }

    //    和谐数组是指一个数组里元素的最大值和最小值之间的差别正好是1。
    //现在，给定一个整数数组，你需要在所有可能的子序列中找到最长的和谐子序列的长度。
    //示例 1:
    //输入: [1,3,2,2,5,2,3,7]
    //    输出: 5
    //原因: 最长的和谐数组是：[3,2,2,2,3].
    //说明: 输入的数组长度最大不超过20,000.

    public int FindLHS(int[] nums)
    {
        Dictionary<int, int> numDic = new Dictionary<int, int>();
        int res = 0;
        foreach(var num in nums)
        {
            if (numDic.ContainsKey(num))
            {
                numDic[num]++;
            }
            else
            {
                numDic.Add(num, 1);
            }
            if (numDic.ContainsKey(num - 1))
            {
                res = Math.Max(res, numDic[num - 1] + numDic[num]);
            }
            if (numDic.ContainsKey(num + 1))
            {
                res = Math.Max(res, numDic[num + 1] + numDic[num]);
            }
        }
        return res;
    }
}
