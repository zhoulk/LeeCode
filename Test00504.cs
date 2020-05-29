using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test00504 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ConvertToBase7(-7));
    }

    //    给定一个整数，将其转化为7进制，并以字符串形式输出。
    //示例 1:
    //输入: 100
    //输出: "202"
    //示例 2:
    //输入: -7
    //输出: "-10"
    //注意: 输入范围是[-1e7, 1e7] 。

    public string ConvertToBase7(int num)
    {
        if(num == 0)
        {
            return "0";
        }

        StringBuilder sb = new StringBuilder("");
        int flag = num >= 0 ? 1 : -1;
        num = Math.Abs(num);
        while (num > 0)
        {
            int n = num % 7;
            sb.Insert(0,n);
            num = num / 7;
        }
        if(flag == -1)
        {
            sb.Insert(0, '-');
        }
        return sb.ToString();
    }
}
