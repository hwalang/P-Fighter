using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestScriptDropDown : MonoBehaviour
{
    public TextMeshProUGUI m_text;

    public void OnValueChanged(int index)
    {
        m_text.text = index.ToString();
    }
}
