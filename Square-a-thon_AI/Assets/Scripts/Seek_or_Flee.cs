using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek_or_Flee : MonoBehaviour {

    // Current position of the Player Object
    public Transform player;

    // Current position of the AI_Seek or AI_Flee object
    private Transform enemy;

    private Rigidbody enemyRB;

    // Boolean that determines whether the object seeks or flees
    public bool seekOrFlee = true;

    // The speed at which the AI object will go
    public float forwardSpeed = 2f;

    public float maxDist = 5f;

    // Initialized on startup
    void Start()
    {

        // Sets the current transformation of the AI_Seek object to a Transformation called enemy
        enemy = transform;

        enemyRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate () {

        // Determines whether the seekOrFlee boolean is true
        if(seekOrFlee == true)
        {       

                // Tells the AI_Seek object to set its forward position towards the Player Object
                transform.LookAt(player.position, Vector3.up);

            if (Vector3.Distance(player.position, enemy.position) >= maxDist)
            {

                // Constantly updates the AI_Seek object's position to be moving towards the Player object, where its speed is based on the forwardSpeed float
                enemy.position += enemy.forward * forwardSpeed * Time.deltaTime;

            }
            /*else
            {
                enemyRB.velocity = new Vector3(0, 0, 0);
            }*/
        }

        // Determines whether the seekOrFlee boolean is false
        else if (seekOrFlee == false)
        {            

                // Tells the AI_Seek object to set its forward position away from the Player Object
                transform.LookAt(2 * enemy.position - player.position, Vector3.up);

            if (Vector3.Distance(player.position, enemy.position) <= maxDist)
            {

                // Constantly updates the AI_Seek object's position to be moving away from the Player object, where its speed is based on the forwardSpeed float
                enemy.position -= -enemy.forward * forwardSpeed * Time.deltaTime;

            }
        }
    }
}
