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
                Debug.Log("��ǥ ��ü�� deactive ��Ų��");
                m_targetObject.SetActive(false);
            }
            else
            {
                Debug.Log("��ǥ ��ü�� active ��Ų��");
                m_targetObject.SetActive(true);
            }
        }
    }
}
