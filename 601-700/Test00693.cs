using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00693 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(HasAlternatingBits(5));
    }

    //    给定一个正整数，检查他是否为交替位二进制数：换句话说，就是他的二进制数相邻的两个位数永不相等。
    //示例 1:
    //输入: 5
    //输出: True
    //解释:
    //5的二进制数是: 101
    //示例 2:
    //输入: 7
    //输出: False
    //解释:
    //7的二进制数是: 111
    //示例 3:
    //输入: 11
    //输出: False
    //解释:
    //11的二进制数是: 1011
    // 示例 4:
    //输入: 10
    //输出: True
    //解释:
    //10的二进制数是: 1010

    //public bool HasAlternatingBits(int n)
    //{
    //    int pre = n % 2;
    //    n = n / 2;
    //    while (n > 0)
    //    {
    //        if(pre == n % 2)
    //        {
    //            return false;
    //        }
    //        pre = n % 2;
    //        n = n / 2;
    //    }
    //    return true;
    //}

    public bool HasAlternatingBits(int n)
    {
        n = n ^ (n >> 1);
        return ((n+1)&n) == 0;
    }
}
