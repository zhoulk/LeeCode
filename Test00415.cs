using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test00415 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(AddStrings("110", "990"));
    }

    //    给定两个字符串形式的非负整数 num1 和num2 ，计算它们的和。

    //注意：

    //num1 和num2的长度都小于 5100.
    //num1 和num2 都只包含数字 0-9.
    //num1 和num2 都不包含任何前导零。
    //你不能使用任何內建 BigInteger 库， 也不能直接将输入的字符串转换为整数形式。

    public string AddStrings(string num1, string num2)
    {
        int len1 = num1.Length;
        int len2 = num2.Length;
        int len = len1 > len2 ? len1 : len2;

        StringBuilder sb = new StringBuilder("");
        int extr = 0;
        for (int i=0; i<len; i++)
        {
            int n1 = 0;
            int n2 = 0;
            if (i < len1)
            {
                n1 = num1[len1 - i - 1] - '0';
            }
            if (i < len2)
            {
                n2 = num2[len2 - i - 1] - '0';
            }
            int sum = n1 + n2 + extr;
            int cur = sum % 10;
            extr = sum / 10;

            sb.Insert(0,cur);
        }
        if(extr > 0)
        {
            sb.Insert(0, extr);
        }

        return sb.ToString();
    }
}
