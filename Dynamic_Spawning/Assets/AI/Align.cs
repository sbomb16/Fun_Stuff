using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align {

    public Kinematics character;
    public GameObject target;

    public float maxAngularAccel = 100f;
    public float maxRotation = 45f;

    public float targetRad = 1f;
    public float slowRad = 10f;

    public float timeToTarget = 0.1f;

    public float rotation;
    public float rotationSize;

    public float angularAccel;

    public SteeringOutput GetSteering()
    {
        SteeringOutput result = new SteeringOutput();

        //rotation = Mathf.DeltaAngle(character.transform.eulerAngles.y - target.transform.eulerAngles.y);

        Debug.Log(target);

        rotation = Mathf.DeltaAngle(character.transform.rotation.eulerAngles.y, target.transform.rotation.eulerAngles.y);
        rotationSize = Mathf.Abs(rotation);

        //Debug.Log(rotation);
        //Debug.Log(rotationSize);

        float targetRotation = 0.0f;

        //if(rotationSize < targetRad)
        //{
        //    return null;
        //}

        if(rotationSize > slowRad)
        {
            targetRotation = maxRotation;
        }

        else
        {
            targetRotation = maxRotation * rotationSize / slowRad;
        }

        targetRotation *= rotation / rotationSize;

        float currentAngularVelocity = float.IsNaN(character.angularVel) ? 0f : character.angularVel;

        //Debug.Log(currentAngularVelocity);

        result.angular = targetRotation - currentAngularVelocity;
        result.angular /= timeToTarget;

        //Debug.Log(result.angular);

        angularAccel = Mathf.Abs(result.angular);

        if(angularAccel > maxAngularAccel)
        {
            result.angular /= angularAccel;
            result.angular *= maxAngularAccel;
        }


        //Debug.Log(result.angular);
        result.linear = Vector3.zero;

        //Debug.Log("The angular result is: " + result.angular);
        return result;
    }
}
