using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00506 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strArr = FindRelativeRanks(new int[] { 1, 4, 3, 2, 5 });
        foreach(var s in strArr)
        {
            Debug.Log(s);
        }
    }

    //    给出 N 名运动员的成绩，找出他们的相对名次并授予前三名对应的奖牌。
    // 前三名运动员将会被分别授予 “金牌”，“银牌” 和“ 铜牌”（"Gold Medal", "Silver Medal", "Bronze Medal"）。
    //(注：分数越高的选手，排名越靠前。)
    //示例 1:
    //输入: [5, 4, 3, 2, 1]
    //    输出: ["Gold Medal", "Silver Medal", "Bronze Medal", "4", "5"]
    //    解释: 前三名运动员的成绩为前三高的，因此将会分别被授予 “金牌”，“银牌”和“铜牌” ("Gold Medal", "Silver Medal" and "Bronze Medal").
    //余下的两名运动员，我们只需要通过他们的成绩计算将其相对名次即可。
    //提示:
    //N 是一个正整数并且不会超过 10000。
    //所有运动员的成绩都不相同。

    //public string[] FindRelativeRanks(int[] nums)
    //{
    //    List<int> orderNums = new List<int>();
    //    orderNums.AddRange(nums);
    //    orderNums.Sort((i,j)=>
    //    {
    //        return j.CompareTo(i);
    //    });

    //    List<string> res = new List<string>();
    //    for(int i=0; i<nums.Length; i++)
    //    {
    //        int rank = orderNums.IndexOf(nums[i]);
    //        if(rank == 0)
    //        {
    //            res.Add("Gold Medal");
    //        }
    //        else if (rank == 1)
    //        {
    //            res.Add("Silver Medal");
    //        }
    //        else if (rank == 2)
    //        {
    //            res.Add("Bronze Medal");
    //        }
    //        else
    //        {
    //            res.Add((rank+1).ToString());
    //        }
    //    }

    //    return res.ToArray();
    //}

    public string[] FindRelativeRanks(int[] nums)
    {
        int max = 0;
        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] > max)
            {
                max = nums[i];
            }
        }

        int[] indexArr = new int[max + 1];
        for(int i=0; i<nums.Length; i++)
        {
            indexArr[nums[i]] = i+1;
        }

        string[] res = new string[nums.Length];
        int index = 1;
        for (int i = indexArr.Length-1; i >=0; i--)
        {
            if(indexArr[i] > 0)
            {
                if(index == 1)
                {
                    res[indexArr[i]-1] = "Gold Medal";
                }
                else if (index == 2)
                {
                    res[indexArr[i]-1] = "Silver Medal";
                }
                else if (index == 3)
                {
                    res[indexArr[i]-1] = "Bronze Medal";
                }
                else
                {
                    res[indexArr[i]-1] = index.ToString();
                }

                index++;
            }
        }

        return res;
    }
}
