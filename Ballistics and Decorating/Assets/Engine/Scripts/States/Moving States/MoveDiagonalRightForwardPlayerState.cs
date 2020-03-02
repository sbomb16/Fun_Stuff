﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDiagonalRightForwardPlayerState : IPlayerStates
{

    public void Enter(Player player)
    {
        Debug.Log("Entered Moving Diagonal Forward Right");
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        Rigidbody rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.AddForce(10, 0, 10);

        if (!Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {

            MoveForwardPlayerState movingForward = new MoveForwardPlayerState();
            movingForward.Enter(player);
        }

        if (!Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {

            MoveRightPlayerState movingRight = new MoveRightPlayerState();
            movingRight.Enter(player);
        }

        if(!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D))
        {
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            // transition to ducking
            DuckingPlayerState duckingState = new DuckingPlayerState();
            duckingState.Enter(player);

        }

        if (Input.GetKey(KeyCode.Space) && player.onGround == true)
        {
            JumpingPlayerState jumpingState = new JumpingPlayerState();
            jumpingState.Enter(player);
        }
    }
}
