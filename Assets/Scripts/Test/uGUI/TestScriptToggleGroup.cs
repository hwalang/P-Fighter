using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScriptToggleGroup : MonoBehaviour
{
    public ToggleGroup m_toggleGroup;
    public Text m_text;

    public void ToggleGroupSelection()
    {
        IEnumerator<Toggle> toggleEnum = m_toggleGroup.ActiveToggles().GetEnumerator();
        toggleEnum.MoveNext();

        Toggle selectedToggle = toggleEnum.Current;

        Text selectedText = selectedToggle.GetComponentInChildren<Text>();
        m_text.text = selectedText.text;
    }
}
