using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00459 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(RepeatedSubstringPattern("abac"));
    }


    //    给定一个非空的字符串，判断它是否可以由它的一个子串重复多次构成。
    //    给定的字符串只含有小写英文字母，并且长度不超过10000。

    //示例 1:
    //输入: "abab"
    //输出: True
    //解释: 可由子字符串 "ab" 重复两次构成。
    //示例 2:
    //输入: "aba"
    //输出: False
    //示例 3:
    //输入: "abcabcabcabc"
    //输出: True
    //解释: 可由子字符串 "abc" 重复四次构成。 (或者子字符串 "abcabc" 重复两次构成。)

    public bool RepeatedSubstringPattern(string s)
    {
        char first = s[0];
        int step = 0;

        while (step < s.Length)
        {
            bool findStep = false;
            for (int i = step+1; i < s.Length; i++)
            {
                if (first == s[i])
                {
                    findStep = true;
                    step = i;
                    break;
                }
            }

            if (!findStep)
            {
                return false;
            }

            bool isOK = true;
            if (step > s.Length / 2)
            {
                return false;
            }

            int j = step-1;
            for(int i=s.Length-1; i > step; i--)
            {
                if(s[i] != s[j])
                {
                    isOK = false;
                    break;
                }
                else
                {
                    j--;
                    if (j < 0)
                    {
                        j = step-1;
                    }
                }
            }
            //Debug.Log(isOK + "  " + step + "  " + j);
            if (isOK && j == 0)
            {
                return true;
            }
        }

        return false;
    }
}
