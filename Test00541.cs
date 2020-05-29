using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test00541 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ReverseStr("abcdefg", 8));
    }

    //给定一个字符串 s 和一个整数 k，你需要对从字符串开头算起的每隔 2k 个字符的前 k 个字符进行反转。
    //如果剩余字符少于 k 个，则将剩余字符全部反转。
    //如果剩余字符小于 2k 但大于或等于 k 个，则反转前 k 个字符，其余字符保持原样。

    //示例:
    //输入: s = "abcdefg", k = 2
    //输出: "bacdfeg"
    //提示：
    //该字符串只包含小写英文字母。
    //给定字符串的长度和 k 在[1, 10000] 范围内。

    public string ReverseStr(string s, int k)
    {
        char[] cArr = s.ToCharArray();
        for(int i=0; i< cArr.Length; i+=2*k)
        {
            int len = k;
            if(i+k >= cArr.Length){
                len = cArr.Length - i;
            }
            for(int j=0; j<len/2; j++)
            {
                char c = cArr[i+j];
                cArr[i + j] = cArr[i + len - j - 1];
                cArr[i + len - j - 1] = c;
            }
        }
        return new string(cArr);
    }
}
