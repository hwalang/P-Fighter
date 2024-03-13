using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggering: " + gameObject.name);

        Field field = other.gameObject.GetComponent<Field>();
        field.actionDelegate += CowAction;

        // field.Activate();
    }

    void CowAction()
    {
        Debug.Log(gameObject.name + ": Do cow actions");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
