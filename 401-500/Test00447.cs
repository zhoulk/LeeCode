using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00447 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[][] points = new int[5][];
        points[0] = new int[2] { 0, 0 };
        points[1] = new int[2] { 1, 0 };
        points[2] = new int[2] { -1, 0 };
        points[3] = new int[2] { 0, 1 };
        points[4] = new int[2] { 0, -1 };

        Debug.Log(NumberOfBoomerangs(points));

        int xxx = 0;
        Debug.Log(xxx++);
        Debug.Log(xxx++);
    }

    //    给定平面上 n 对不同的点，“回旋镖” 是由点表示的元组(i, j, k)，其中 i和 j之间的距离和 i和 k之间的距离相等（需要考虑元组的顺序）。

    //找到所有回旋镖的数量。你可以假设 n 最大为 500，所有点的坐标在闭区间[-10000, 10000] 中。

    //示例:

    //输入:
    //[[0,0],[1,0],[2,0]]

    //输出:
    //2

    //解释:
    //两个回旋镖为[[1, 0],[0,0],[2,0]] 和[[1, 0],[2,0],[0,0]]

    public int NumberOfBoomerangs(int[][] points)
    {
        int total = 0;
        for (int i = 0; i < points.Length; i++)
        {
            int[] firstPoint = points[i];
            int[] tempArr = new int[points.Length];

            for (int j = 0; j < points.Length; j++)
            {
                if(i == j)
                {
                    continue;
                }
                int[] secondPoint = points[j];

                tempArr[j] = (firstPoint[0] - secondPoint[0]) * (firstPoint[0] - secondPoint[0]) + (firstPoint[1] - secondPoint[1]) * (firstPoint[1] - secondPoint[1]);
            }
            total += sameLen(tempArr);
            //string str = "";
            //for (int x = 0; x < tempArr.Length; x++)
            //{
            //    str += tempArr[x] + ",";
            //}
            //Debug.Log(firstPoint[0] + " " + firstPoint[1] + " " + sameLen(tempArr) + " " + str);
        }
        return total * 2;
    }

    int sameLen(int[] lenArr)
    {
        int num = 0;
        for (int i = 0; i < lenArr.Length; i++)
        {
            int first = lenArr[i];
            for (int j = i+1; j < lenArr.Length; j++)
            {
                int second = lenArr[j];
                if (first == second)
                {
                    num++;
                }
            }
        }
        return num;
    }
}
