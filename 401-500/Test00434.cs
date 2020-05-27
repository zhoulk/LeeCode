using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00434 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CountSegments("  Hello,   my name    is John  "));
    }

    //    统计字符串中的单词个数，这里的单词指的是连续的不是空格的字符。

    //请注意，你可以假定字符串里不包括任何不可打印的字符。

    //示例:

    //输入: "Hello, my name is John"
    //输出: 5
    //解释: 这里的单词是指连续的不是空格的字符，所以 "Hello," 算作 1 个单词。

    public int CountSegments(string s)
    {
        int i = 0;
        int word = 0;
        bool intoWord = false;
        while (i<s.Length)
        {
            char c = s[i];
            if(c == ' ')
            {
                if (intoWord)
                {
                    intoWord = false;
                    word++;
                }
            }
            else
            {
                intoWord = true;
            }
            i++;
        }
        if (intoWord)
        {
            word++;
        }

        return word;
    }
}
