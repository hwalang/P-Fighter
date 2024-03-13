using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggering: " + gameObject.name);

        Field field = other.gameObject.GetComponent<Field>();
        field.actionDelegate += HumanAction;
    }

    void HumanAction()
    {
        Debug.Log(gameObject.name + ": Do human actions");
    }
}
