using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00441 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ArrangeCoins(5));
    }

    //你总共有 n枚硬币，你需要将它们摆成一个阶梯形状，第 k行就必须正好有 k枚硬币。

    //给定一个数字 n，找出可形成完整阶梯行的总行数。

    //n 是一个非负整数，并且在32位有符号整型的范围内。

    //示例 1:

    //n = 5

    //硬币可排列成以下几行:
    //¤
    //¤ ¤
    //¤ ¤

    //因为第三行不完整，所以返回2.
    //示例 2:

    //n = 8

    //硬币可排列成以下几行:
    //¤
    //¤ ¤
    //¤ ¤ ¤
    //¤ ¤

    //因为第四行不完整，所以返回3.

    public int ArrangeCoins(int n)
    {
        int row = 0;
        while (n > row)
        {
            n -= row;
            if(n > row)
            {
                row++;
            }
        }

        return row;
    }
}
