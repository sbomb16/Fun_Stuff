using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("s"))
        {
            EventBus.TriggerEvent("shoot");
        }
        if (Input.GetKeyDown("w"))
        {
            EventBus.TriggerEvent("drop");
        }
        if (Input.GetKeyDown("g"))
        {
            EventBus.TriggerEvent("inverse");
        }
        if (Input.GetKeyDown("e"))
        {
            EventBus.TriggerEvent("expand");
        }
	}
}
