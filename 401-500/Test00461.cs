using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00461 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(HammingDistance(1, 4));
    }

    //    两个整数之间的汉明距离指的是这两个数字对应二进制位不同的位置的数目。
    //给出两个整数 x 和 y，计算它们之间的汉明距离。
    //注意：
    //0 ≤ x, y< 231.
    //示例:
    //输入: x = 1, y = 4
    //输出: 2
    //解释:
    //1   (0 0 0 1)
    //4   (0 1 0 0)
    //       ↑   ↑
    //上面的箭头指出了对应二进制位不同的位置。

    public int HammingDistance(int x, int y)
    {
        int s = x ^ y;
        int distance = 0;
        while(s > 0)
        {
            if((s&1) == 1)
            {
                distance++;
            }
            s = s >> 1;
        }
        return distance;
    }
}
