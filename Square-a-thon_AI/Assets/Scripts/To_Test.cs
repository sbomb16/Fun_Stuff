using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_Test : MonoBehaviour {

    // When called, this function loads in the AI_Test scene
	public void ToTest()
    {

        // Finds and loads the AI_Test scene by referencing its build index
        SceneManager.LoadScene(5);

    }
}
