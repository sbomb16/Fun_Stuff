using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    // Variable that represents the Player object's Rigidbody
    public Rigidbody rb;

    private Vector3 move;
    private Vector3 force;

    // Float that determines the force applied to the Player object on the Z axis
    public float forwardForce = 50f;

    // Float that determines the force applied to the Player object on the X axis
    public float sideForce = 10f;

    // Float that determines how many jumps the Player object has remaining
    //public float jumpsRemaining = 3f;

    public bool doubleJump = false;

    // Vector that contains the variable that determines the force that's applied to the Player object in the positive Y direction 
    public Vector3 jumpHeight = new Vector3(0, 10, 0);

    // Boolean that determines whether the Player object is on the ground or not
    public bool isOnGround = true;

    // Boolean that determines whether the Player object can double jump
    public bool canDoubleJump = false;

    public float rotationSpeed;
    public float movementSpeed;

    public float rotation;

    public GameObject finder;

    public bool canJump;

    public float projectiles;

    private void Start()
    {
        finder = Resources.Load("Finder") as GameObject;
    }

    // This function controls the jumping feature
    void Jumping()
    {

        // Checks to see if the isOnGround boolean is true
        if(isOnGround == true)
        {

            // An impulse force is added in the positive Y direction
            rb.AddForce(jumpHeight, ForceMode.Impulse);

            // Sets the isOnGround boolean to false
            isOnGround = false;

            // Reduces the jumpsRemaining float by 1
            //jumpsRemaining--;

        }

        // Checks to see if the isOnGround boolean is false and if the doubleJump boolean is true
        else if(isOnGround == false && doubleJump == true)
        {

            // An impulse force is added in the positive Y direction
            rb.AddForce(jumpHeight, ForceMode.Impulse);            

            // Sets the doubleJump boolean to false
            doubleJump = false;

        }        
    }

    // Update is called once per frame
    void Update () {

        // Continuously applies a force to the Player object in the positive Z direction using the forwardForce float
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        //transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        //Constantly checks to see if the player presses the "d" key
        //if (Input.GetKey("d"))
        //{

        //    // A force is added to the Player object in the positive X direction using the sideForce float
        //    rb.AddForce(sideForce, 0, 0);
        //    rb.transform.Rotate(0, rotation, 0);

        //}

        //// Constantly checks to see if the player presses the "a" key 
        //if (Input.GetKey("a"))
        //{

        //    // A force is added to the Player object in the negative X direction using the sideForce float
        //    rb.AddForce(-sideForce, 0, 0);
        //    rb.transform.Rotate(0, -rotation, 0);

        //}

        //// Constantly checks to see if the player presses the "s" key
        //if (Input.GetKey("s"))
        //{

        //    // A force is added to the Player object in the negative Z direction using the forwardForce float
        //    rb.AddForce(0, 0, -forwardForce);

        //}
        //if (Input.GetKey("w"))
        //{
        //    // A force is added to the Player object in the negative Z direction using the forwardForce float
        //    rb.AddForce(0, 0, forwardForce);
        //}

        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");

        move = Camera.main.transform.TransformDirection(move.x, 0, move.z);

        force = move.normalized * forwardForce;

        rb.AddForce(force);

        // Constantly checks to see if the player has pressed the spacebar and that the jumpsRemaining float is greater than 0
        if(canJump == true)
        {
            if (Input.GetKeyDown("space") && canDoubleJump == false)
            {

                // Calls the Jumping function
                Jumping();

                // Sets the canDoubleJump boolean to true
                canDoubleJump = true;

            }

            // Constantly checks to see if the player has released the spacebar
            if (Input.GetKeyUp("space"))
            {

                // Sets the canDoubleJump boolean to false
                canDoubleJump = false;

            }
        }
        else
        {
            if (Input.GetKeyDown("space"))
            {
                if (projectiles > 0)
                {
                    Debug.Log("Woah");
                    Instantiate(finder, transform.position, transform.rotation);
                    projectiles--;
                }
            }                  
        }
        


        // Constantly checks to see if the Player object has fallen below -1 on the Y axis
        if(rb.position.y < -5f)
        {

            // Calls the EndGame function from the Game_Manager script
            FindObjectOfType<Game_Manager>().EndGame();

        }        
    }
}
