using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test00557 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ReverseWords("Let's take LeetCode contest"));
    }

    //    给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。
    //示例 1:
    //输入: "Let's take LeetCode contest"
    //输出: "s'teL ekat edoCteeL tsetnoc" 
    //注意：在字符串中，每个单词由单个空格分隔，并且字符串中不会有任何额外的空格。
    public string ReverseWords(string s)
    {
        StringBuilder sb = new StringBuilder();
        string[] words = s.Split(' ');
        for(int i=0; i<words.Length; i++)
        {
            char[] cArr = words[i].ToCharArray();
            revers(cArr);
            sb.Append(cArr).Append(' ');
        }
        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }

    void revers(char[] word)
    {
        int i = 0;
        int j = word.Length - 1;
        while (i < j)
        {
            char c = word[i];
            word[i] = word[j];
            word[j] = c;
            i++;
            j--;
        }
    }
}
