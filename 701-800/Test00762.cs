using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00762 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CountPrimeSetBits(6, 10));
    }

    //    给定两个整数 L和 R ，找到闭区间[L, R] 范围内，计算置位位数为质数的整数个数。
    //（注意，计算置位代表二进制表示中1的个数。例如 21 的二进制表示 10101 有 3 个计算置位。还有，1 不是质数。）
    //示例 1:
    //输入: L = 6, R = 10
    //输出: 4
    //解释:
    //6 -> 110 (2 个计算置位，2 是质数)
    //7 -> 111 (3 个计算置位，3 是质数)
    //9 -> 1001 (2 个计算置位，2 是质数)
    //10-> 1010 (2 个计算置位，2 是质数)
    //示例 2:
    //输入: L = 10, R = 15
    //输出: 5
    //解释:
    //10 -> 1010 (2 个计算置位, 2 是质数)
    //11 -> 1011 (3 个计算置位, 3 是质数)
    //12 -> 1100 (2 个计算置位, 2 是质数)
    //13 -> 1101 (3 个计算置位, 3 是质数)
    //14 -> 1110 (3 个计算置位, 3 是质数)
    //15 -> 1111 (4 个计算置位, 4 不是质数)
    //注意:
    //L, R 是L <= R 且在[1, 10 ^ 6]中的整数。
    //R - L 的最大值为 10000。
    public int CountPrimeSetBits(int L, int R)
    {
        int cnt = 0;
        for(int i=L; i<=R; i++)
        {
            if (isPrimier(numberOf1(i)))
            {
                cnt++;
            }
        }
        return cnt;
    }

    int numberOf1(int i)
    {
        int count = 0;
        int flag = 1;
        while (flag != 0)
        {
            if((i & flag) != 0)
            {
                count++;
            }
            flag = flag << 1;
        }
        return count;
    }

    bool isPrimier(int num)
    {
        if(num == 1)
        {
            return false;
        }
        if(num == 2)
        {
            return true;
        }
        for(int i=2; i<=Math.Sqrt(num)+1; i++)
        {
            if(num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
