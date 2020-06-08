using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00633 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(JudgeSquareSum(2));
    }

    //    给定一个非负整数 c ，你要判断是否存在两个整数 a 和 b，使得 a2 + b2 = c。
    //示例1:
    //输入: 5
    //输出: True
    //解释: 1 * 1 + 2 * 2 = 5
    //示例2:
    //输入: 3
    //输出: False

    public bool JudgeSquareSum(int c)
    {
        int i = 0;
        int j = (int)Math.Sqrt(c);
        while (i <= j)
        {
            long sum = i * i + j * j;
            if(sum == c)
            {
                return true;
            }
            else if(sum < c)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return false;
    }

    //public bool JudgeSquareSum(int c)
    //{
    //    for (int i = 2; i * i <= c; i++)
    //    {
    //        int count = 0;
    //        if (c % i == 0)
    //        {
    //            while (c % i == 0)
    //            {
    //                count++;
    //                c /= i;
    //            }
    //            if (i % 4 == 3 && count % 2 != 0)
    //                return false;
    //        }
    //    }
    //    return c % 4 != 3;
    //}

    //public bool JudgeSquareSum(int c)
    //{
    //    for (int i = 0; i * i <= c; i++)
    //    {
    //        double b = Math.Sqrt(c - i * i);
    //        if (b == (int)b)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}

    //public bool JudgeSquareSum(int c)
    //{
    //    for(int i=0; i*i<=c; i++)
    //    {
    //        int b = c - i * i;
    //        if (binary_search(0, b, b)){
    //            return true;
    //        }
    //    }
    //    return false;
    //}

    bool binary_search(long s, long e, int n)
    {
        if (s > e)
        {
            return false;
        }
        long mid = s + (e - s) / 2;
        if(mid * mid == n)
        {
            return true;
        }
        if(mid * mid > n)
        {
            return binary_search(s, mid-1, n);
        }
        return binary_search(mid+1, e, n);
    }
}
