using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funny_Man : Enemy {

	public void Do_Funny_Thing()
    {
        Debug.Log("This is so funny hahaha! Woah!");
    }

    private void Update()
    {
        Do_Funny_Thing();
    }

}
