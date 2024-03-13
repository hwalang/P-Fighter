using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class TestScriptAction : MonoBehaviour
{
    Action actionVar;
    Action<int, int> actionVar2;

    void action1()
    {
        Debug.Log("action1");
    }

    void action2(int a, int b)
    {
        Debug.Log("action2: " + (a + b).ToString());
    }

    void Start()
    {
        actionVar += action1;
        actionVar2 += action2;

        action1();
        action2(2, 3);
    }

}
