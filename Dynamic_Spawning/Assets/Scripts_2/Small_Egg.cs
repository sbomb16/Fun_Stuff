using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_Eggs : MonoBehaviour, INPC, iCopyable
{

    // Puts a specific phrase into the debug menu when called
    public void Speak()
    {

        // Puts a specific phrase into the debug menu
        Debug.Log("Yes, I am The egg.");

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