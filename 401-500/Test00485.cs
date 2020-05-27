using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00485 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1}));
    }

    //    给定一个二进制数组， 计算其中最大连续1的个数。
    //示例 1:
    //输入: [1,1,0,1,1,1]
    //    输出: 3
    //解释: 开头的两位和最后的三位都是连续1，所以最大连续1的个数是 3.
    //注意：
    //输入的数组只包含 0 和1。
    //输入数组的长度是正整数，且不超过 10,000。

    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int len = 0;
        int max = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(1 == nums[i])
            {
                len++;
            }
            else
            {
                if(len > max)
                {
                    max = len;
                }
                len = 0;
            }
        }
        if (len > max)
        {
            max = len;
        }
        return max;
    }
}
