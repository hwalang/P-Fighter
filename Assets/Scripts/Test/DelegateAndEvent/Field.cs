using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public delegate void Action();

    public event Action actionDelegate;

    public void Activcate()
    {
        if (actionDelegate != null)
        {
            actionDelegate();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) )
        {
            Activcate();
        }
    }
}
