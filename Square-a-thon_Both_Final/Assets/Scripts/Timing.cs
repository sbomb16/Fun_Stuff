using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timing : MonoBehaviour {

    // Reference to the Text object
    public Text timer;

    // Float that will store the Time.deltaTime value
    public float timerNum;


	// Update is called once per frame
	void Update () {

        // Constantly sets the timerNum to the current in-scene time
        timerNum += Time.deltaTime;

        // Sets the timerNum float to the timer Text object
        timer.text = timerNum.ToString("0");

    }
}
