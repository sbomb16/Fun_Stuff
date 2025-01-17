﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDiagonalLeftBackwardsPlayerState : IPlayerStates
{

    public void Enter(Player player)
    {
        Debug.Log("Entered Moving Diagonal Backwards Left");
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        Rigidbody rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.AddForce(-10, 0, -10);

        if (!Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {

            MoveBackwardsPlayerState movingBackwards = new MoveBackwardsPlayerState();
            movingBackwards.Enter(player);
        }

        if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {

            MoveLeftPlayerState movingLeft = new MoveLeftPlayerState();
            movingLeft.Enter(player);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            // transition to ducking
            DuckingPlayerState duckingState = new DuckingPlayerState();
            duckingState.Enter(player);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            JumpingPlayerState jumpingState = new JumpingPlayerState();
            jumpingState.Enter(player);
        }
    }
}
