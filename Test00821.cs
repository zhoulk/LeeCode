using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00821 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(ShortestToChar("loveleetcode", 'e'));
        int[] nums = ShortestToChar("loveleetcode", 'e');
        foreach(var n in nums)
        {
            Debug.Log(n);
        }
    }

    //    给定一个字符串 S和一个字符 C。返回一个代表字符串 S中每个字符到字符串 S中的字符 C的最短距离的数组。
    //示例 1:
    //输入: S = "loveleetcode", C = 'e'
    //输出: [3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0]
    //    说明:
    //字符串 S的长度范围为[1, 10000]。
    //C 是一个单字符，且保证是字符串 S里的字符。
    //S 和C 中的所有字母均为小写字母。
    public int[] ShortestToChar(string S, char C)
    {
        int[] arr = new int[S.Length];

        int prev = int.MinValue / 2;
        for(int i=0; i<S.Length; i++)
        {
            if(S[i] == C)
            {
                prev = i;
            }
            arr[i] = i - prev;
        }

        prev = int.MaxValue /2 ;
        for (int i = S.Length-1; i >= 0; i--)
        {
            if (S[i] == C)
            {
                prev = i;
            }
            arr[i] = Math.Min(prev-i, arr[i]);
        }
        return arr;
    }
}
