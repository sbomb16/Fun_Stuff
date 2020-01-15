using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jumps : MonoBehaviour {

    // Text element that's used to display the current amount of jumps remaining
    public Text jumps;

    // Instance of the Player_Movement script
    public Player_Movement movement;

	// Update is called once per frame
	void Update ()
    {
        // Gets the jumpsRemaining float from the Player_Movement script instance and applies it to the jumps Text variable by converting the float to a string
        jumps.text = movement.jumpsRemaining.ToString("0");

	}
}
