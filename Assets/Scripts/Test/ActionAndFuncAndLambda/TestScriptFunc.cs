using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class TestScriptFunc : MonoBehaviour
{
    Func<int> funcVar1;
    Func<int, int, int> funcVar2;

    int func1()
    {
        Debug.Log("func1");
        return 0;
    }

    int func2(int a, int b)
    {
        Debug.Log("func2");
        return a + b;
    }

    void Start()
    {
        funcVar1 += func1;
        funcVar2 += func2;

        Debug.Log( func1() );
        Debug.Log(func2(1, 2));

    }
}
