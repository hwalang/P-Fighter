using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestScriptInputField : MonoBehaviour
{
    public TextMeshProUGUI m_text;
    public TMP_InputField m_InputField;

    public void OnEndEdit()
    {
        string inputStr = m_InputField.text;
        string outputStr = inputStr.Replace(" ", "");

        m_text.text = outputStr;
    }

    public void OnSelect()
    {
        Debug.Log("OnSelect");
    }
    public void OnDeSelect()
    {
        Debug.Log("OnDeSelect");
    }
}
