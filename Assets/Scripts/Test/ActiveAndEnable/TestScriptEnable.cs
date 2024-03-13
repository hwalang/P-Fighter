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
                Debug.Log("���� ���� �ֽ��ϴ�.");
                Debug.Log("���� ���ϴ�.");
                light.enabled = false;
            }
            else
            {
                Debug.Log("���� ���� �ֽ��ϴ�.");
                Debug.Log("���� ŵ�ϴ�.");
                light.enabled = true;
            }
        }
    }
}
