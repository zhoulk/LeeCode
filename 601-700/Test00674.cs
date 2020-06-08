using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00674 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindLengthOfLCIS(new int[] { 1, 3, 5, 4, 7 }));
    }

    //    给定一个未经排序的整数数组，找到最长且连续的的递增序列。
    //示例 1:
    //输入: [1,3,5,4,7]
    //    输出: 3
    //解释: 最长连续递增序列是[1, 3, 5], 长度为3。
    //尽管[1, 3, 5, 7] 也是升序的子序列, 但它不是连续的，因为5和7在原数组里被4隔开。 
    //示例 2:
    //输入: [2,2,2,2,2]
    //    输出: 1
    //解释: 最长连续递增序列是[2], 长度为1。
    //注意：数组长度不会超过10000。
    public int FindLengthOfLCIS(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int max = 0;
        int len = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                len++;
                max = len > max ? len : max;
            }
            else
            {
                len = 0;
            }
        }
        return max + 1;
    }

    //public int FindLengthOfLCIS(int[] nums)
    //{
    //    if (nums.Length == 0)
    //        return 0;
    //    int dp = 1, max = 1;
    //    for (int i = 1; i < nums.Length; i++)
    //    {
    //        if (nums[i - 1] < nums[i])
    //        {
    //            dp++;
    //            max = max > dp ? max : dp;
    //        }
    //        else
    //            dp = 1;
    //    }
    //    return max;
    //}
}
