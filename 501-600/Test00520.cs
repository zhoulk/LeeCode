using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00520 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DetectCapitalUse("mL"));
    }

    //    给定一个单词，你需要判断单词的大写使用是否正确。

    //我们定义，在以下情况时，单词的大写用法是正确的：

    //全部字母都是大写，比如"USA"。
    //单词中所有字母都不是大写，比如"leetcode"。
    //如果单词不只含有一个字母，只有首字母大写， 比如 "Google"。
    //否则，我们定义这个单词没有正确使用大写字母。

    //示例 1:
    //输入: "USA"
    //输出: True
    //示例 2:
    //输入: "FlaG"
    //输出: False
    //注意: 输入是由大写和小写拉丁字母组成的非空单词。

    public bool DetectCapitalUse(string word)
    {
        if(word.Length == 1)
        {
            return true;
        }

        bool isSmall = word[0] > 'Z';
        if ((isSmall && word[1] < 'a'))
        {
            return false;
        }
        isSmall = word[1] > 'Z';
        for (int i=2; i<word.Length; i++)
        {
            if ((isSmall && word[i] < 'a')
                || (!isSmall && word[i] > 'Z'))
            {
                return false;
            }
        }

        return true;
    }
}
