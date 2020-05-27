using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00500 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strArr = FindWords(new string[] { "Hello", "Alaska", "Dad", "Peace" });
        foreach (var s in strArr)
        {
            Debug.Log(s);
        }
    }

    //    给定一个单词列表，只返回可以使用在键盘同一行的字母打印出来的单词。键盘如下图所示。







    //示例：
    //输入: ["Hello", "Alaska", "Dad", "Peace"]
    //    输出: ["Alaska", "Dad"]
    //    注意：
    //你可以重复使用键盘上同一字符。
    //你可以假设输入的字符串将只包含字母。
    public string[] FindWords(string[] words)
    {
        Dictionary<char, int> cDic = new Dictionary<char, int>
        {
            { 'q', 3 }, {'w',3 },{'e',3 },{'r',3 },{'t',3 },{'y',3 },{'u',3 },{'i',3 },{'o',3 },{'p',3 },
            { 'a',2 },{'s',2 },{'d',2 },{'f',2 },{'g',2 },{'h',2 },{'j',2 },{'k',2 },{'l',2 },
            { 'z',1 },{ 'x',1 }, {'c',1 }, {'v',1 }, {'b',1 }, {'n',1 }, {'m',1 } 
        };

        List<string> res = new List<string>();
        for(int i=0; i<words.Length; i++)
        {
            string w = words[i].ToLower();
            int first = cDic[w[0]];
            bool isFind = true;
            for(int j=1; j< words[i].Length; j++)
            {
                if(first != cDic[w[j]])
                {
                    isFind = false;
                    break;
                }
            }
            if (isFind)
            {
                res.Add(words[i]);
            }
        }
        return res.ToArray();
    }
}
