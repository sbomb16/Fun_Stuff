using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    // Contains the Player object's position
    public Transform player;

    // Text element that's used to display the player's current score
    public Text scoreText;
    
	// Update is called once per frame
	void Update () {

        // Constantly tracks the Player object's Z position, and sets it to the Score text as a whole number
        scoreText.text = player.position.z.ToString("0");
		
	}
}
