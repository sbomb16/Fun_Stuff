﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public IPlayerStates mCurrentState;

	// Use this for initialization
	void Start () {
        mCurrentState = new StandingPlayerState();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        mCurrentState.Execute(this);
	}
}
