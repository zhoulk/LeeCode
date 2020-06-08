using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00645 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = FindErrorNums(new int[] { 2,2 });
        foreach(var n in nums)
        {
            Debug.Log(n);
        }
    }

    //    集合 S 包含从1到 n的整数。不幸的是，因为数据错误，导致集合里面某一个元素复制了成了集合里面的另外一个元素的值，
    // 导致集合丢失了一个整数并且有一个元素重复。
    //给定一个数组 nums 代表了集合 S 发生错误后的结果。你的任务是首先寻找到重复出现的整数，再找到丢失的整数，
    // 将它们以数组的形式返回。
    //示例 1:
    //输入: nums = [1,2,2,4]
    //    输出: [2,3]
    //    注意:
    //给定数组的长度范围是[2, 10000]。
    //给定的数组是无序的。
    public int[] FindErrorNums(int[] nums)
    {
        int dup = -1, missing = 0;
        foreach(int n in nums)
        {
            if(nums[Math.Abs(n)-1] < 0)
            {
                dup = Math.Abs(n);
            }
            else
            {
                nums[Math.Abs(n) - 1] *= -1;
            }
        }
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                missing = i + 1;
            }
        }
        return new int[] { dup, missing};
    }
}
