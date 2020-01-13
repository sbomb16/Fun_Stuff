using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    // When called, this function will load the next scene based on their build index
    public void Begin()
    {

        // Finds and loads the next scene based on the current scene's build index
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
