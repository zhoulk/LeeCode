using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00507 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CheckPerfectNumber(28));
    }

    //    对于一个 正整数，如果它和除了它自身以外的所有正因子之和相等，我们称它为“完美数”。
    //给定一个 整数n， 如果他是完美数，返回 True，否则返回 False
    //示例：
    //输入: 28
    //输出: True
    //解释: 28 = 1 + 2 + 4 + 7 + 14
    //提示：
    //输入的数字 n 不会超过 100,000,000. (1e8)

    public bool CheckPerfectNumber(int num)
    {
        if(num == 1)
        {
            return false;
        }

        int sum = 0;
        int w = (int)Math.Sqrt(num);
        while(w > 1)
        {
            if(num % w == 0)
            {
                sum += (num / w + w);
            }
            w--;
        }
        return (sum+1) == num;
    }
}
