using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventScript : MonoBehaviour
{
    public GameObject m_effectPrefab;

    public void ActionVoid()
    {
        GameObject obj = (GameObject)Instantiate(m_effectPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(obj, 0.5f);
        Debug.Log("ActionVoid");
    }

    public void ActionInt(int a)
    {
        Debug.Log(a);
    }

    public void ActionFloat(float a)
    {
        Debug.Log(a);
    }

    public void ActionString(string a)
    {
        Debug.Log(a);
    }

    public void ActionEvent(AnimationEvent a)
    {
        Debug.Log(a.floatParameter);
        Debug.Log(a.intParameter);
        Debug.Log(a.stringParameter);
        Debug.Log(a.objectReferenceParameter);
    }
}
