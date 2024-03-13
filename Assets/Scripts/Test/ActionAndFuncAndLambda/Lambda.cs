using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lambda : MonoBehaviour
{
    Action act1;
    Func<int, int, int> func3;

    void Start()
    {
        act1 += () => Debug.Log("lambda1");
        func3 += (int a, int b) =>
        {
            Debug.Log("lambda2: " + (a + b).ToString());
            return a + b;
        };

        act1();
        Debug.Log(func3(1, 2));
    }
}
