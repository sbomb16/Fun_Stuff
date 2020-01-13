using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Trigger : MonoBehaviour {

    // Instance of the Game_Manager script
    public Game_Manager gameManager;

    // This function is called when the Player object enters a trigger area
    void OnTriggerEnter(Collider other)
    {
        // Calls the CompleteLevel fucntion in the Game_Manager script
        gameManager.CompleteLevel();
    }
}
