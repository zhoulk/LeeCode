using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00628 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log( MaximumProduct(new int[] { 1, 2, 3, 4 }));
    }

    //    给定一个整型数组，在数组中找出由三个数组成的最大乘积，并输出这个乘积。
    //示例 1:
    //输入: [1,2,3]
    //    输出: 6
    //示例 2:
    //输入: [1,2,3,4]
    //    输出: 24
    //注意:
    //给定的整型数组长度范围是[3, 104]，数组中所有的元素范围是[-1000, 1000]。
    //输入的数组中任意三个数的乘积不会超出32位有符号整数的范围。
    public int MaximumProduct(int[] nums)
    {
        Array.Sort(nums);
        return Math.Max(nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3],
            nums[nums.Length - 1] * nums[0] * nums[1]);
    }
}
