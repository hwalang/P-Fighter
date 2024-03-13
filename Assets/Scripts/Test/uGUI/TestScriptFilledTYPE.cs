using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TestScriptFilledTYPE : MonoBehaviour
{
    public Image m_image;
    public float m_speed;   // 채우는 속도

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            m_image.fillAmount += Time.deltaTime * m_speed;
        } else
        {
            m_image.fillAmount -= Time.deltaTime * m_speed;
        }
    }
}
