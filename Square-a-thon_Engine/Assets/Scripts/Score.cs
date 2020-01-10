using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    
	// Update is called once per frame
	void Update () {

        // Constantly finds the Player object's Z position, and sets it to the Score text as a whole number
        scoreText.text = player.position.z.ToString("0");
		
	}
}
