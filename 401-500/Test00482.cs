﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Test00482 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(LicenseKeyFormatting("---", 3));
    }

    // 有一个密钥字符串 S ，只包含字母，数字以及 '-'（破折号）。其中， N 个 '-' 将字符串分成了 N+1 组。
    // 给你一个数字 K，请你重新格式化字符串，除了第一个分组以外，每个分组要包含 K 个字符；
    // 而第一个分组中，至少要包含 1 个字符。两个分组之间需要用 '-'（破折号）隔开，并且将所有的小写字母转换为大写字母。
    // 给定非空字符串 S 和数字 K，按照上面描述的规则进行格式化。

    //示例 1：
    //输入：S = "5F3Z-2e-9-w", K = 4
    //输出："5F3Z-2E9W"
    //解释：字符串 S 被分成了两个部分，每部分 4 个字符；
    //     注意，两个额外的破折号需要删掉。
    //示例 2：
    //输入：S = "2-5g-3-J", K = 2
    //输出："2-5G-3J"
    //解释：字符串 S 被分成了 3 个部分，按照前面的规则描述，第一部分的字符可以少于给定的数量，其余部分皆为 2 个字符。

    //提示:
    //S 的长度可能很长，请按需分配大小。K 为正整数。
    //S 只包含字母数字（a-z，A-Z，0-9）以及破折号'-'
    //S 非空

    //public string LicenseKeyFormatting(string S, int K)
    //{
    //    StringBuilder res = new StringBuilder("");
    //    int j = 0;
    //    for(int i=S.Length-1; i>=0; i--)
    //    {
    //        if (j < K)
    //        {
    //            if (S[i] != '-')
    //            {
    //                j++;
    //                res.Insert(0, S[i]);
    //            }
    //        }
    //        else
    //        {
    //            j = 0;
    //            res.Insert(0, '-');
    //            i++;
    //        }
    //    }
    //    if(res.Length > 0 && res[0] == '-')
    //    {
    //       res.Remove(0,1);
    //    }
    //    return res.ToString().ToUpper();
    //}

    public string LicenseKeyFormatting(string S, int K)
    {
        StringBuilder res = new StringBuilder("");
        int j = 0;
        for (int i = S.Length - 1; i >= 0; i--)
        {
            if (j < K)
            {
                if (S[i] != '-')
                {
                    j++;
                    res.Append(S[i]);
                }
            }
            else
            {
                j = 0;
                res.Append('-');
                i++;
            }
        }

        for(int k=0; k<res.Length/2; k++)
        {
            char temp = res[k];
            res[k] = res[res.Length - k - 1];
            res[res.Length - k - 1] = temp;
        }

        if (res.Length > 0 && res[0] == '-')
        {
            res.Remove(0, 1);
        }
        return res.ToString().ToUpper();
    }
}
