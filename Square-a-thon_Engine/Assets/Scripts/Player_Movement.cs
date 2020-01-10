using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sideForce = 100f;    

	// Update is called once per frame
	void FixedUpdate () {

        // Continuously applies a force to the Player object in the positive Z direction using the forwardForce float
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        // Constantly checks to see if the player presses the "d" key
        if (Input.GetKey("d"))
        {
            // A force is added to the Player object in the positive X direction using the sideForce float
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Constantly checks to see if the player presses the "a" key 
        else if (Input.GetKey("a"))
        {
            // A force is added to the Player object in the negative X direction using the sideForce float
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }               
	}
}
