using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00443 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }));
    }

    //    给定一组字符，使用原地算法将其压缩。

    //压缩后的长度必须始终小于或等于原数组长度。

    //数组的每个元素应该是长度为1 的字符（不是 int 整数类型）。

    //在完成原地修改输入数组后，返回数组的新长度。



    //进阶：
    //你能否仅使用O(1) 空间解决问题？



    //示例 1：

    //输入：
    //["a","a","b","b","c","c","c"]

    //    输出：
    //返回6，输入数组的前6个字符应该是：["a","2","b","2","c","3"]

    //    说明：
    //"aa"被"a2"替代。"bb"被"b2"替代。"ccc"被"c3"替代。
    //示例 2：

    //输入：
    //["a"]

    //    输出：
    //返回1，输入数组的前1个字符应该是：["a"]

    //    说明：
    //没有任何字符串被替代。
    //示例 3：

    //输入：
    //["a","b","b","b","b","b","b","b","b","b","b","b","b"]

    //    输出：
    //返回4，输入数组的前4个字符应该是：["a","b","1","2"]。

    //说明：
    //由于字符"a"不重复，所以不会被压缩。"bbbbbbbbbbbb"被“b12”替代。
    //注意每个数字在数组中都有它自己的位置。
    //注意：

    //所有字符都有一个ASCII值在[35, 126] 区间内。
    //1 <= len(chars) <= 1000。

    //public int Compress(char[] chars)
    //{
    //    int index = 0;
    //    int count = 1;
    //    char pre = chars[0];
    //    for(int i=1; i<chars.Length; i++)
    //    {
    //        char c = chars[i];
    //        if(pre != c)
    //        {
    //            if (count > 1)
    //            {
    //                chars[index] = pre;
    //                index++;

    //                char[] lenArr = count.ToString().ToCharArray();
    //                for (int j = 0; j < lenArr.Length; j++)
    //                {
    //                    chars[index] = lenArr[j];
    //                    index++;
    //                }
    //            }
    //            else
    //            {
    //                chars[index] = pre;
    //                index++;
    //            }

    //            pre = c;
    //            count = 1;
    //        }
    //        else
    //        {
    //            count++;
    //        }
    //    }

    //    if (count > 1)
    //    {
    //        chars[index] = pre;
    //        index++;

    //        char[] lenArr = count.ToString().ToCharArray();
    //        for (int j = 0; j < lenArr.Length; j++)
    //        {
    //            chars[index] = lenArr[j];
    //            index++;
    //        }
    //    }
    //    else
    //    {
    //        chars[index] = pre;
    //        index++;
    //    }

    //    //Debug.Log(new string(chars));

    //    return index;
    //}

    public int Compress(char[] chars)
    {
        int write = 0;
        int read = 0;
        int anchor = 0;
        for (; read < chars.Length; read++)
        {
            if (read == chars.Length-1 || chars[read+1] != chars[read])
            {
                chars[write++] = chars[anchor];
                if(read > anchor)
                {
                    foreach(var c in (read - anchor + 1).ToString().ToCharArray())
                    {
                        chars[write++] = c;
                    }
                }
                anchor = read+1;
            }
        }

        //Debug.Log(new string(chars));

        return write;
    }
}
