using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beggars : MonoBehaviour, INPC, iCopyable {    

    // Puts a specific phrase into the debug menu when called
	public void Speak()
    {
        // Puts a specific phrase into the debug menu
        Debug.Log("Gimme that cash, please. I need it for a smidge of the ol brimstone.");

    }  

    // Calls an instance of the Copy function from the iCopyable script
    public iCopyable Copy()
    {

        // Calls the Speak() function
        Speak();

        // Returns an instantiated instance of this class
        return Instantiate(this);

    }
}
