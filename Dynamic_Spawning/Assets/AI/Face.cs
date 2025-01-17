﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : Align
{

    //public new GameObject target;
    //public Align alignment;

    public Vector3 direction;

    public SteeringOutput GetSteering()
    {

        //Debug.Log(target);

        direction = target.transform.position - character.transform.position;

        if (direction.magnitude == 0)
        {

            return null;

        }

        
        float angle = Mathf.Atan2(direction.x, direction.z);
        angle *= Mathf.Rad2Deg;
        target.transform.eulerAngles = new Vector3(0 ,angle, 0);
        return base.GetSteering();

    }

}
