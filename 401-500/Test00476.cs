using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00476 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FindComplement(1));
    }

    //    给定一个正整数，输出它的补数。补数是对该数的二进制表示取反。
    //示例 1:
    //输入: 5
    //输出: 2
    //解释: 5 的二进制表示为 101（没有前导零位），其补数为 010。所以你需要输出 2 。
    //示例 2:

    //输入: 1
    //输出: 0
    //解释: 1 的二进制表示为 1（没有前导零位），其补数为 0。所以你需要输出 0 。

    //注意:
    //给定的整数保证在 32 位带符号整数的范围内。
    //你可以假定二进制数不包含前导零位。
    //本题与 1009 https://leetcode-cn.com/problems/complement-of-base-10-integer/ 相同

    public int FindComplement(int num)
    {
        int res = 0;
        int len = 0;
        while (num > 0)
        {
            //Debug.Log(num + "  " + (num & 1) + "  " + ((num & 1)^1));

            res |= ((num & 1) ^ 1) << len;
            num = num >> 1;
            len++;
            //Debug.Log(res);
        }
        return res;
    }
}
