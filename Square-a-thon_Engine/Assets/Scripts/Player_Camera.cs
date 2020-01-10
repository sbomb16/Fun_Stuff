using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Camera : MonoBehaviour {

    public Transform player;
    public Vector3 offset;	

    // Update is called once per frame
	void Update () {

        // Applies the Player object's position to the Main camera, which is then offset with the offset Vector3
        transform.position = player.position + offset;

	}   
}
