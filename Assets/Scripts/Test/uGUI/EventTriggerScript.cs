using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerScript : MonoBehaviour
{
    public GameObject m_target;

    private void Start()
    {
        EventTrigger trigger = m_target.GetComponent<EventTrigger>();

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerEnter;
        entry.callback.AddListener( (data) => { Destroy(m_target); });

        trigger.triggers.Add(entry);
    }
}
