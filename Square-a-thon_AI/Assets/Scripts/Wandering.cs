using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : MonoBehaviour {

    // Float that sets the AI's speed
    public float boySpeed = 10f;

    // Vector3 that contains the randomly generated points
    public Vector3 goTowards;

    // Floats that determine what the X values can range from in the randomize function
    public float rangeX_1 = 10f;
    public float rangeX_2 = 10f;

    // Floats that determine what the Z values can range from in the randomize function
    public float rangeZ_1 = 10f;
    public float rangeZ_2 = 10f;

    // Floats that contains the randomized X and Z range values
    private float range_X;
    private float range_Z;

    // Initialized on startup
    void Start()
    {

        // Calls the Wander function on startup
        Wander();

    }

    // This function finds a random coordinate based on the range values
    void Wander()
    {

        // Uses the preset rangeX_1, rangeX_2, rangeZ_1, and rangeZ_2 floats to find a random float for rangeX and rangeZ respectively 
        range_X = Random.Range(transform.position.x - rangeX_1, transform.position.x + rangeX_2);
        range_Z = Random.Range(transform.position.z - rangeZ_1, transform.position.z + rangeZ_2);

        // The X and Z variables are set in the goTowards Vector3 using the ranges found above
        goTowards = new Vector3(range_X, 0.75f, range_Z);

        // The Y value of the Wander object is set to always be 0.75
        goTowards.y = 0.75f;

        // The Wander object is set to look at the goTowards Vector3
        transform.LookAt(goTowards);

    }

    // Updates on a fixed interval
    void FixedUpdate()
    {

        // Constantly moves the Wander object's position towards the goTowards Vector3
        transform.position += transform.TransformDirection(Vector3.forward) * boySpeed * Time.deltaTime;
        
        // Checks to see if the magnitude of Wander object's position and the goTowards Vector3 is less than 1
        if((transform.position - goTowards).magnitude < 1)
        {

            // Calls the Wander function
            Wander();

        }
    }
}
