using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptActive : MonoBehaviour
{
    public GameObject m_targetObject;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (m_targetObject.activeInHierarchy)
            {
                Debug.Log("목표 객체를 deactive 시킨다");
                m_targetObject.SetActive(false);
            }
            else
            {
                Debug.Log("목표 객체를 active 시킨다");
                m_targetObject.SetActive(true);
            }
        }
    }
}
