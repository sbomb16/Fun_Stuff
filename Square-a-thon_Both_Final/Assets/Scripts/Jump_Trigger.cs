using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump_Trigger : MonoBehaviour {

    // Instance of the Player_Movement script
    public Player_Movement movement;

    // This function is called when the Player object enters a trigger area
    void OnTriggerEnter(Collider other)
    {

        // Resets the jump counter to 3
        movement.jumpsRemaining = 3;

    }
}
