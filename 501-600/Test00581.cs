using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00581 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindUnsortedSubarray(new int[] { 1,2,3,3,3 }));
    }

    //    给定一个整数数组，你需要寻找一个连续的子数组，如果对这个子数组进行升序排序，那么整个数组都会变为升序排序。
    //你找到的子数组应是最短的，请输出它的长度。
    //示例 1:
    //输入: [2, 6, 4, 8, 10, 9, 15]
    //    输出: 5
    //解释: 你只需要对[6, 4, 8, 10, 9] 进行升序排序，那么整个表都会变为升序排序。
    //说明 :
    //输入的数组长度范围在[1, 10, 000]。
    //输入的数组可能包含重复元素 ，所以升序的意思是<=。
    public int FindUnsortedSubarray(int[] nums)
    {
        int[] num2 = new int[nums.Length];
        Array.Copy(nums, num2, nums.Length);
        Array.Sort(num2);
        int i = 0;
        int j = nums.Length-1;
        bool isStart = false;
        bool isEnd = false;
        while ((!isStart || !isEnd) && i<j)
        {
            if(num2[i] == nums[i])
            {
                i++;
            }
            else
            {
                isStart = true;
            }
            if (num2[j] == nums[j])
            {
                j--;
            }
            else
            {
                isEnd = true;
            }
        }
        return j>i?(j-i+1) : 0;
    }
}
