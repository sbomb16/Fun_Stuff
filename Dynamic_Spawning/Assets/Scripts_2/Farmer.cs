using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmers : MonoBehaviour, INPC, iCopyable
{

    // Puts a specific phrase into the debug menu when called
    public void Speak()
    {

        // Puts a specific phrase into the debug menu
        Debug.Log("Where the eff are mahworkers?! Mah animals?! MAH WIFE??!");

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
