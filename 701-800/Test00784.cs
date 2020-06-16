using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test00784 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //    给定一个字符串S，通过将字符串S中的每个字母转变大小写，我们可以获得一个新的字符串。返回所有可能得到的字符串集合。
    //示例:
    //输入: S = "a1b2"
    //输出: ["a1b2", "a1B2", "A1b2", "A1B2"]
    //    输入: S = "3z4"
    //输出: ["3z4", "3Z4"]
    //    输入: S = "12345"
    //输出: ["12345"]
    //    注意：
    //S 的长度不超过12。
    //S 仅由数字和字母组成。
    public IList<string> LetterCasePermutation(string S)
    {
        List<string> res = new List<string>();
        for (int i=0; i<S.Length; i++)
        {
            char ch = S[i];
            if (ch >= 65 && ch <= 90 || ch >= 97 && ch <= 122)
            {
                StringBuilder s = new StringBuilder(S);
                res.Add(s.ToString());
                s[i] = (char)(ch ^ 32);
                res.Add(s.ToString());
            }
        }
        return res;
    }

    //public IList<string> LetterCasePermutation(string S)
    //{
    //    List<string> res = new List<string>();
    //    dfs(new StringBuilder(S), 0, res);
    //    return res;
    //}

    void dfs(StringBuilder s, int index, List<string> res)
    {
        if(index >= s.Length)
        {
            res.Add(s.ToString());
            return;
        }
        char ch = s[index];
        if(ch >= 65 && ch <= 90 || ch >= 97 && ch <= 122)
        {
            dfs(s, index + 1, res);                 // 搜索原字母的组合
            s[index] = (char)(ch ^ 32);
            dfs(s, index + 1, res);
        }
        else
        {
            dfs(s, index + 1, res);
        }
    }
}
