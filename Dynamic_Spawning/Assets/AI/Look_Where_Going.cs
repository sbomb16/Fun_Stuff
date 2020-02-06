using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_Where_Going : Align
{

    //public Align getThings;

    public SteeringOutput GetSteering()
    {
        Vector3 velocity = character.linearVel;

        if (velocity.magnitude == 0)
        {
            return null;
        }

        float angle = Mathf.Atan2(-velocity.x, velocity.z) * Mathf.Rad2Deg;
        angle *= Mathf.Rad2Deg;
        target.transform.eulerAngles = new Vector3(0, angle, 0);

        return base.GetSteering();
    }
}
