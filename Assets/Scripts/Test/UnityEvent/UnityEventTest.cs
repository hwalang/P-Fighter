using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class UnityEventTest : MonoBehaviour
{
    public delegate void Action();
    public event Action actionDelegate;

    public UnityEvent actionEvent0;
    public UnityEvent<int> actionEvent1;
    public UnityEvent<float, bool> actionEvent2;

    public void DoAction()
    {
        Debug.Log("DoAction1");
    }

    public void DoAction2(int a)
    {
        Debug.Log(a);
    }

    private void Start()
    {
        actionEvent0.AddListener(DoAction);
        actionEvent1.AddListener(DoAction2);

        if (actionEvent0 != null)
        {
            actionEvent0.Invoke();
        }

        if (actionEvent1 != null)
        {
            actionEvent1.Invoke(3);
        }

        actionEvent0.RemoveListener(DoAction);
    }
}
