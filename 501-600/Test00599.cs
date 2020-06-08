using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00599 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strs = FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" },
        new string[] { "KFC", "Shogun", "Burger King" });
        foreach(var s in strs)
        {
            Debug.Log(s);
        }
    }

    //    假设Andy和Doris想在晚餐时选择一家餐厅，并且他们都有一个表示最喜爱餐厅的列表，每个餐厅的名字用字符串表示。
    //你需要帮助他们用最少的索引和找出他们共同喜爱的餐厅。 如果答案不止一个，则输出所有答案并且不考虑顺序。 
    //你可以假设总是存在一个答案。
    //示例 1:
    //输入:
    //["Shogun", "Tapioca Express", "Burger King", "KFC"]
    //    ["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"]
    //    输出: ["Shogun"]
    //    解释: 他们唯一共同喜爱的餐厅是“Shogun”。
    //示例 2:
    //输入:
    //["Shogun", "Tapioca Express", "Burger King", "KFC"]
    //    ["KFC", "Shogun", "Burger King"]
    //    输出: ["Shogun"]
    //    解释: 他们共同喜爱且具有最小索引和的餐厅是“Shogun”，它有最小的索引和1(0+1)。
    //提示:
    //两个列表的长度范围都在[1, 1000] 内。
    //两个列表中的字符串的长度将在[1，30] 的范围内。
    //下标从0开始，到列表的长度减1。
    //两个列表都没有重复的元素。

    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        Dictionary<string, int> tempDic = new Dictionary<string, int>();
        List<string> res = new List<string>();
        int min = int.MaxValue;
        for(int i=0; i<list1.Length; i++)
        {
            tempDic[list1[i]] = i;
        }
        for (int i = 0; i < list2.Length; i++)
        {
            if (tempDic.ContainsKey(list2[i])){
                if((tempDic[list2[i]] + i) < min)
                {
                    min = Math.Min(min, tempDic[list2[i]] + i);
                    res.Clear();
                    res.Add(list2[i]);
                }
                else if((tempDic[list2[i]] + i) == min)
                {
                    res.Add(list2[i]);
                }
            }
        }
        return res.ToArray();
    }
}
