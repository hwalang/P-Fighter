using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestScriptSlider : MonoBehaviour
{
    public TextMeshProUGUI m_text;
    public Slider m_slider;

    void Start()
    {
        ValueChangedAction();
    }

    public void ValueChangedAction()
    {
        int currentValue = (int)m_slider.value;
        m_text.text = currentValue.ToString();
    }
}
