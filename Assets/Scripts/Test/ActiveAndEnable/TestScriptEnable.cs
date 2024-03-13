using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptEnable : MonoBehaviour
{
    public Light light;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (light.enabled)
            {
                Debug.Log("불이 켜져 있습니다.");
                Debug.Log("불을 끕니다.");
                light.enabled = false;
            }
            else
            {
                Debug.Log("불이 꺼져 있습니다.");
                Debug.Log("불을 킵니다.");
                light.enabled = true;
            }
        }
    }
}
