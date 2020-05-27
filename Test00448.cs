using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00448 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<int> nums = (List<int>)FindDisappearedNumbers(new int[]{ 4,3,2,7,8,2,3,1});
        foreach (var i in nums){
            Debug.Log(i);
        }
    }

    //    给定一个范围在  1 ≤ a[i] ≤ n(n = 数组大小) 的 整型数组，数组中的元素一些出现了两次，另一些只出现一次。

    //找到所有在[1, n] 范围之间没有出现在数组中的数字。

    //您能在不使用额外空间且时间复杂度为O(n)的情况下完成这个任务吗? 你可以假定返回的数组不算在额外空间内。

    //示例:

    //输入:
    //[4,3,2,7,8,2,3,1]

    //    输出:
    //[5,6]

    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> list = new List<int>();
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[Math.Abs(nums[i])-1] > 0)
            {
                nums[Math.Abs(nums[i]) - 1] = -1 * nums[Math.Abs(nums[i]) - 1];
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                list.Add(i+1);
            }
        }
        return list;
    }
}
