using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Collision : MonoBehaviour {

    public Player_Movement movement;

    // Detects whether an object has made a collision
    void OnCollisionEnter(Collision coll)
    {
        // This checks to see if the Player object has hit an object with the Obstacle tag
        if(coll.collider.tag == "Obstacle")
        {
            // Disables the Player object's movement when an object with the Obstacle tag is hit
            movement.enabled = false;
        }
    }
}
