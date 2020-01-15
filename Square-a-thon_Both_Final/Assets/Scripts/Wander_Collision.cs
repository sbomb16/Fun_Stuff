using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander_Collision : MonoBehaviour {

    // Reference to the Wandering script
    public Wandering wander;
    
    // Constantly checks to see if the Player object has collided with anything
    void OnCollisionEnter(Collision coll)
    {

        // This checks to see if the Player object has hit an object with the Obstacle tag
        if (coll.collider.tag == "Obstacle")
        {

            // Disables the Player object's movement when an object with the Obstacle tag is hit
            wander.enabled = false;

            // Calls the EndGame function from the Game_Manager script
            FindObjectOfType<Game_Manager>().EndGame();
            
        }        
    }    
}
