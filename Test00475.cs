using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00475 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindRadius(new int[] {1,2,3,4}, new int[] { 1,4 }));
    }

    //    冬季已经来临。 你的任务是设计一个有固定加热半径的供暖器向所有房屋供暖。
    //现在，给出位于一条水平线上的房屋和供暖器的位置，找到可以覆盖所有房屋的最小加热半径。
    //所以，你的输入将会是房屋和供暖器的位置。你将输出供暖器的最小加热半径。
    //说明:

    //给出的房屋和供暖器的数目是非负数且不会超过 25000。
    //给出的房屋和供暖器的位置均是非负数且不会超过10^9。
    //只要房屋位于供暖器的半径内(包括在边缘上)，它就可以得到供暖。
    //所有供暖器都遵循你的半径标准，加热的半径也一样。
    //示例 1:

    //输入: [1,2,3],[2]
    //    输出: 1
    //解释: 仅在位置2上有一个供暖器。如果我们将加热半径设为1，那么所有房屋就都能得到供暖。
    //示例 2:

    //输入: [1,2,3,4],[1,4]
    //    输出: 1
    //解释: 在位置1, 4上有两个供暖器。我们需要将加热半径设为1，这样所有房屋就都能得到供暖。

    //public int FindRadius(int[] houses, int[] heaters)
    //{
    //    int len = 0;
    //    for(int i=0; i<houses.Length; i++)
    //    {
    //        int left = int.MaxValue;
    //        int right = int.MaxValue;
    //       for(int j=0; j<heaters.Length; j++)
    //       {
    //            if(houses[i] > heaters[j])
    //            {
    //                if(Math.Abs(houses[i] - heaters[j]) < left)
    //                {
    //                    left = Math.Abs(houses[i] - heaters[j]);
    //                }
    //            }
    //            else
    //            {
    //                if (Math.Abs(houses[i] - heaters[j]) < right)
    //                {
    //                    right = Math.Abs(houses[i] - heaters[j]);
    //                }
    //            }
    //       }
    //        int n = Math.Min(left, right);
    //        if (n > len)
    //        {
    //            len = n;
    //        }
    //    }
    //    return len;
    //}

    public int FindRadius(int[] houses, int[] heaters)
    {
        Array.Sort(houses);
        Array.Sort(heaters);

        int i = 0;
        int j = 0;
        int temp = 0;
        int max = 0;
        while(i< houses.Length && j<heaters.Length)
        {
            //Debug.Log(houses[i] + "  " + heaters[j]);
            if (houses[i] <= heaters[j])
            {
                temp = heaters[j] - houses[i];
                i++;
            }
            else if (j < heaters.Length-1)
            {
                temp = Math.Min(heaters[j + 1] - houses[i], houses[i] - heaters[j]);
                if (houses[i] < heaters[j+1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            else if(j == heaters.Length - 1)
            {
                temp = houses[i] - heaters[j];
                i++;
            }
            max = max > temp ? max : temp;
        }

        return max;
    }
}
