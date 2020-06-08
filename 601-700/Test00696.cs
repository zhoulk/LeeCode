using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00696 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CountBinarySubstrings("00110011"));
    }

    //    给定一个字符串 s，计算具有相同数量0和1的非空(连续)子字符串的数量，并且这些子字符串中的所有0和所有1都是组合在一起的。
    //重复出现的子串要计算它们出现的次数。
    //示例 1 :
    //输入: "00110011"
    //输出: 6
    //解释: 有6个子串具有相同数量的连续1和0：“0011”，“01”，“1100”，“10”，“0011” 和 “01”。
    //请注意，一些重复出现的子串要计算它们出现的次数。
    //另外，“00110011”不是有效的子串，因为所有的0（和1）没有组合在一起。
    //示例 2 :
    //输入: "10101"
    //输出: 4
    //解释: 有4个子串：“10”，“01”，“10”，“01”，它们具有相同数量的连续1和0。
    //注意：
    //s.length 在1到50,000之间。
    //s 只包含“0”或“1”字符。

    //public int CountBinarySubstrings(string s)
    //{
    //    int all = 0;
    //    for(int i=0; i<s.Length; i++)
    //    {
    //        char a = s[i];
    //        int j = i+1;
    //        int len = 1;
    //        bool isSame = true;

    //        while (j < s.Length)
    //        {
    //            if(s[j] == a)
    //            {
    //                if (isSame)
    //                {
    //                    len++;
    //                }
    //                else
    //                {
    //                    break;
    //                }
    //            }
    //            else
    //            {
    //                if (isSame)
    //                {
    //                    isSame = false;
    //                }
    //                len--;
    //                if(len == 0)
    //                {
    //                    all++;
    //                    break;
    //                }
    //            }
    //            j++;
    //        }
    //    }
    //    return all;
    //}

    public int CountBinarySubstrings(string s)
    {
        int all = 0;
        int len1 = 0;
        int len2 = 0;
        char pre = s[0];
        len1 = 1;
        for (int i = 1; i < s.Length; i++)
        {
            if(s[i] == pre)
            {
                len1++;
            }
            else
            {
                if(len2 > 0)
                {
                    all += Math.Min(len1, len2);
                }
                len2 = len1;
                pre = s[i];
                len1 = 1;
            }
        }
        if (len2 > 0)
        {
            all += Math.Min(len1, len2);
        }

        return all;
    }
}
