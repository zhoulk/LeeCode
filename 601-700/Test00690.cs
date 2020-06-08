﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00690 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(GetImportance());
    }

    //    给定一个保存员工信息的数据结构，它包含了员工唯一的id，重要度 和 直系下属的id。
    //比如，员工1是员工2的领导，员工2是员工3的领导。他们相应的重要度为15, 10, 5。
    //那么员工1的数据结构是[1, 15, [2]]，员工2的数据结构是[2, 10, [3]]，员工3的数据结构是[3, 5, []]。
    //注意虽然员工3也是员工1的一个下属，但是由于并不是直系下属，因此没有体现在员工1的数据结构中。
    //现在输入一个公司的所有员工信息，以及单个员工id，返回这个员工和他所有下属的重要度之和。
    //示例 1:
    //输入: [[1, 5, [2, 3]], [2, 3, []], [3, 3, []]], 1
    //输出: 11
    //解释:
    //员工1自身的重要度是5，他有两个直系下属2和3，而且2和3的重要度均为3。因此员工1的总重要度是 5 + 3 + 3 = 11。
    //注意:
    //一个员工最多有一个直系领导，但是可以有多个直系下属
    //员工数量不超过2000。

    public int GetImportance(IList<Employee> employees, int id)
    {
        foreach (var emp in employees)
        {
            if(emp.id == id)
            {
                if (emp.subordinates != null)
                {
                    foreach (var e in emp.subordinates)
                    {
                        emp.importance += GetImportance(employees, e);
                    }
                }
                return emp.importance;
            }
        }

        return 0;
    }
}

public class Employee
{
    public int id;
    public int importance;
    public IList<int> subordinates;
}
