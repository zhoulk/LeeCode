using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test00709 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ToLowerCase("Hello"));
    }

    //    实现函数 ToLowerCase()，该函数接收一个字符串参数 str，并将该字符串中的大写字母转换成小写字母，之后返回新的字符串。
    //示例 1：
    //输入: "Hello"
    //输出: "hello"
    //示例 2：
    //输入: "here"
    //输出: "here"
    //示例 3：
    //输入: "LOVELY"
    //输出: "lovely"
    public string ToLowerCase(string str)
    {
        StringBuilder sb = new StringBuilder();
        char[] cArr = str.ToCharArray();
        for(int i=0; i<cArr.Length; i++)
        {
            if(cArr[i] >= 'A' && cArr[i] <= 'Z')
            {
                cArr[i] = (char)(str[i] + 32);
            }
        }
        sb.Append(cArr);
        return sb.ToString();
    }
}
