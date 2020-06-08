using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00551 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CheckRecord("LLLALL"));
    }

    //    给定一个字符串来代表一个学生的出勤记录，这个记录仅包含以下三个字符：
    //'A' : Absent，缺勤
    //'L' : Late，迟到
    //'P' : Present，到场
    //如果一个学生的出勤记录中不超过一个'A'(缺勤) 并且不超过两个连续的'L'(迟到),那么这个学生会被奖赏。
    //你需要根据这个学生的出勤记录判断他是否会被奖赏。

    //示例 1:
    //输入: "PPALLP"
    //输出: True
    //示例 2:
    //输入: "PPALLL"
    //输出: False

    public bool CheckRecord(string s)
    {
        int aCnt = 0;
        int maxL = 0;
        int lCnt = 0;
        bool inL = false;
        for(int i=0; i<s.Length; i++)
        {
            if(s[i] == 'A')
            {
                aCnt++;
            }
            if(s[i] == 'L')
            {
                if (inL)
                {
                    lCnt++;
                }
                else
                {
                    lCnt = 1;
                }
                inL = true;
            }
            else
            {
                inL = false;
            }
            maxL = Math.Max(maxL, lCnt);
        }
        return aCnt < 2 && maxL <3;
    }
}
