﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This Class manages how the various scenes switch from one another
public class Game_Manager : MonoBehaviour
{

    // Boolean that tracks whether the game should end or not
    bool gameEnded = false;

    // Float that determines the delay from when the Player object hits an obstacle to the end level UI fading in
    public float restartDelay = 1f;

    // Instance of the Level Complete UI GameObject
    public GameObject levelCompleteUI;

    // When called, this function checks to see if a boolean is true or false to determine the gamestate
    public void EndGame()
    {

        // Check to see if the gameEnded boolean is true or false
        if(gameEnded == false)
        {

            // If gameEnded is false, set it to true, then invoke the Restart function
            gameEnded = true;
            Invoke("Restart", restartDelay);

        }        
    }

    // When called, this function will restart the scene
    void Restart()
    {

        // Reloads the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    // When called, this function will enable the level end UI assets
    public void CompleteLevel()
    {

        // Sets the levelCompleteUI GameObject to active
        levelCompleteUI.SetActive(true);

    }

    // When called, this function will quit the application
    public void Exit_Game()
    {

        Debug.Log("Ended");

        // Quits the application
        Application.Quit();

    }
}
