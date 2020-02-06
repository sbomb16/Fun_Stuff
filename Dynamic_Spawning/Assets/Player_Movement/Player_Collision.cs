using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Collision : MonoBehaviour {

    // Instance of the Player_Movement script
    public Player_Movement movement;

    // Detects whether an object has made a collision
    void OnCollisionEnter(Collision coll)
    {

        // This checks to see if the Player object has hit an object with the Obstacle tag
        if(coll.collider.tag == "Obstacle")
        {

            // Disables the Player object's movement when an object with the Obstacle tag is hit
            movement.enabled = false;

            // Calls the EndGame function from the Game_Manager script
            FindObjectOfType<Game_Manager>().EndGame();

        // This checks to see if the Player object has hit an object with the "Platform" tag
        } else if(coll.collider.tag == "Platform")
        {

            // Sets the instance of the isOnGround from the Player_Movement script variable to true
            movement.isOnGround = true;

            // Sets the instance of the doubleJump from the Player_Movement script variable to true
            movement.doubleJump = true;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.ToString() == "Goal")
        {
            SceneManager.LoadScene(0);
        }
    }
}
