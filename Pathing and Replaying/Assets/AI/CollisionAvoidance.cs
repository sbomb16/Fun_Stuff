using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAvoidance
{
    public Kinematics character;
    public float maxAccel = 5f;

    public Kinematics[] targets;

    public float radius = 5f;

    public Kinematics firstTarget;   

    public float shortestTime;
    public float relativeSpeed;
    public float timeToCollision;
    public float distance;
    public float minSeparation;

    public float firstMinSeparation;
    public float firstDist;

    public Vector3 firstRelativePos;
    public Vector3 firstRelativeVel;

    public Vector3 relativePos;
    public Vector3 relativeVel;

    public SteeringOutput GetSteering()
    {
        shortestTime = Mathf.Infinity;

        firstTarget = null;

        for(int i = 0; i < targets.Length-1; i++)
        {
            relativePos = character.transform.position - targets[i].transform.position;
            relativeVel = targets[i].linearVel - character.linearVel;

            relativeSpeed = relativeVel.magnitude;
            timeToCollision = Vector3.Dot(relativePos, relativeVel) / (relativeSpeed * relativeSpeed);

            distance = relativePos.magnitude;
            minSeparation = distance - relativeSpeed * timeToCollision;

            if(minSeparation > 2 * radius)
            {
                Debug.Log("1");
                continue;

            }
            else if(timeToCollision > 0 && timeToCollision < shortestTime)
            {

                shortestTime = timeToCollision;

                firstTarget = targets[i];
                firstMinSeparation = minSeparation;
                firstDist = distance;
                firstRelativePos = relativePos;
                firstRelativeVel = relativeVel;
                Debug.Log(2);
            }
        }

        if (!firstTarget)
        {
            Debug.Log("Oops");
            return null;
        }

        if(firstMinSeparation <= 0 || firstDist < 2 * radius)
        {
            relativePos = firstTarget.transform.position - character.transform.position;
        }
        else
        {
            relativePos = firstRelativePos + firstRelativeVel * shortestTime;
        }

        relativePos.Normalize();

        SteeringOutput result = new SteeringOutput();

        Debug.Log("rad");

        result.linear = relativePos * maxAccel;
        result.angular = 0;
        return result;

    }	
}
