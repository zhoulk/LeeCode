using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00680 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ValidPalindrome("abc"));
    }

    //    给定一个非空字符串 s，最多删除一个字符。判断是否能成为回文字符串。
    //示例 1:
    //输入: "aba"
    //输出: True
    //示例 2:
    //输入: "abca"
    //输出: True
    //解释: 你可以删除c字符。
    //注意:
    //字符串只包含从 a-z 的小写字母。字符串的最大长度是50000。
    public bool ValidPalindrome(string s)
    {
        if (s.Length == 0)
        {
            return true;
        }

        int i = 0;
        int j = s.Length - 1;
        while (i <= j)
        {
            if (s[i] != s[j])
            {
                return isValid(s, i+1, j) || isValid(s, i, j-1);
            }
            i++;
            j--;
        }
        return true;
    }

    bool isValid(string s, int i, int j)
    {
        while (i <= j)
        {
            if (s[i] == s[j])
            {
                i++;
                j--;
            }
            else if (s[i] != s[j])
            {
                return false;
            }
        }
        return true;
    }
}
