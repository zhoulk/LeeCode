using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00704 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 100));
    }

    //    给定一个 n个元素有序的（升序）整型数组 nums 和一个目标值 target  ，写一个函数搜索 nums中的 target，
    // 如果目标值存在返回下标，否则返回 -1。
    //示例 1:
    //输入: nums = [-1,0,3,5,9,12], target = 9
    //输出: 4
    //解释: 9 出现在 nums 中并且下标为 4
    //示例 2:
    //输入: nums = [-1,0,3,5,9,12], target = 2
    //输出: -1
    //解释: 2 不存在 nums 中因此返回 -1
    //提示：
    //你可以假设 nums中的所有元素是不重复的。
    //n 将在[1, 10000]之间。
    //nums 的每个元素都将在[-9999, 9999]之间。
    public int Search(int[] nums, int target)
    {
        int i = 0;
        int j = nums.Length - 1;
        while (i <= j)
        {
            int m = (i + j) / 2;
            if(nums[m] == target)
            {
                return m;
            }
            if(nums[m] < target)
            {
                i = m + 1;
            }
            else
            {
                j = m - 1;
            }
        }
        return -1;
    }
}
