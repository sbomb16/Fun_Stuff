using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Complete : MonoBehaviour {

    // When called, this function will load the next scene based on their build index
	public void LoadNextLevel()
    {

        // Finds and loads the next scene based on the current scene's build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
