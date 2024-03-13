using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    public TextMeshProUGUI m_descText;
    public TextMeshProUGUI m_buttonText;
    public Button m_button;

    public void Setup(string descText, string buttonText, UnityAction doAction)
    {
        m_descText.text = descText;
        m_buttonText.text = buttonText;

        m_button.onClick.AddListener(doAction);
    }
}
