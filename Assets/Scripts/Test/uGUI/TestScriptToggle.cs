using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptToggle : MonoBehaviour
{
    public GameObject m_cube;

    public void OnValueChanged(bool isOn)
    {
        if (isOn)
        {
            m_cube.SetActive(true);
        }
        else
        {
            m_cube.SetActive(false);
        }
    }
}
