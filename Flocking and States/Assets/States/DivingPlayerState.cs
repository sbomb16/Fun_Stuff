using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingPlayerState : IPlayerStates
{

    public void Enter(Player player)
    {
        Debug.Log("Entered Diving");
        player.mCurrentState = this;

        Rigidbody rbPlayer = player.GetComponent<Rigidbody>();
        if(rbPlayer.velocity.normalized.z == 0 && rbPlayer.velocity.normalized.x == 0)
        {
            rbPlayer.AddForce(0, 0, 10, ForceMode.VelocityChange);
        }
        if(rbPlayer.velocity.normalized.z > 0 && rbPlayer.velocity.normalized.x == 0)
        {
            rbPlayer.AddForce(0, 0, 10, ForceMode.VelocityChange);
        }
        if(rbPlayer.velocity.normalized.z < 0 && rbPlayer.velocity.normalized.x == 0)
        {
            rbPlayer.AddForce(0, 0, -10, ForceMode.VelocityChange);
        }
        if(rbPlayer.velocity.normalized.x > 0 && rbPlayer.velocity.normalized.z == 0)
        {
            rbPlayer.AddForce(10, 0, 0, ForceMode.VelocityChange);
        }
        if(rbPlayer.velocity.normalized.x < 0 && rbPlayer.velocity.normalized.z == 0)
        {
            rbPlayer.AddForce(-10, 0, 0, ForceMode.VelocityChange);
        }
        if (rbPlayer.velocity.normalized.z > 0 && rbPlayer.velocity.normalized.x > 0)
        {
            rbPlayer.AddForce(10, 0, 10, ForceMode.VelocityChange);
        }
        if (rbPlayer.velocity.normalized.z > 0 && rbPlayer.velocity.normalized.x < 0)
        {
            rbPlayer.AddForce(-10, 0, 10, ForceMode.VelocityChange);
        }
        if (rbPlayer.velocity.normalized.z < 0 && rbPlayer.velocity.normalized.x > 0)
        {
            rbPlayer.AddForce(10, 0, -10, ForceMode.VelocityChange);
        }
        if (rbPlayer.velocity.normalized.z < 0 && rbPlayer.velocity.normalized.x < 0)
        {
            rbPlayer.AddForce(-10, 0, -10, ForceMode.VelocityChange);
        }
    }

    public void Execute(Player player)
    {
        if (Physics.Raycast(player.transform.position, Vector3.down, 0.55f)){
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                DuckingPlayerState duckingState = new DuckingPlayerState();
                duckingState.Enter(player);
            }
            else
            {
                StandingPlayerState standingState = new StandingPlayerState();
                standingState.Enter(player);
            }
        }
    }
}
