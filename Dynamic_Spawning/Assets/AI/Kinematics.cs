using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kinematics : MonoBehaviour {

    // Position comes from attached gameobject
    // Rotation as well
    public Vector3 linearVel;
    public float angularVel; // Degrees
    public GameObject aiTarget;
    public float maxSpeed = 5f;

    public bool flee;

    public float fleeX = 5f;
    public float fleeZ = 5f;

    public string movementType;

    public Vector3 angularInc = Vector3.zero;

    Seek_And_Flee seeking;
    Arrival arrive;
    //Align aligning;
    
   // Align looking;

    SteeringOutput moving;
    SteeringOutput turning;

    SteeringOutput movement;

	// Use this for initialization
	void Start () {       
		
	}
	
	// Update is called once per frame
	void Update () {

        seeking = new Seek_And_Flee();
        arrive = new Arrival();
        //aligning = new Align();

        SteeringOutput moving = new SteeringOutput();
        SteeringOutput turning = new SteeringOutput();

        seeking.character = this;
        seeking.target = aiTarget;

        arrive.character = this;
        arrive.target = aiTarget;

        SteeringOutput movement = new SteeringOutput();

        switch (movementType)
        {
            case "Seek":
                moving = seeking.GetSteering();

                if (moving == null)
                {
                    movement.linear = Vector3.zero;
                }
                else
                {
                    movement.linear = moving.linear;
                    movement.angular = turning.angular;
                }

                break;

            case "Flee":
                flee = true;

                moving = seeking.GetSteering();

                if (moving == null)
                {
                    movement.linear = Vector3.zero;
                }
                else
                {
                    movement.linear = moving.linear;
                    movement.angular = turning.angular;
                }

                break;

            case "Arrive":
                moving = arrive.GetSteering();

                if (moving == null)
                {
                    movement.linear = Vector3.zero;
                }
                else
                {
                    movement.linear = moving.linear;
                    movement.angular = turning.angular;
                }

                break;

            case "Face":
                Face staticFace = new Face();

                staticFace.target = aiTarget;
                staticFace.character = this;

                //moving = seeking.GetSteering();
                turning = staticFace.GetSteering();

                movement.linear = Vector3.zero;
                movement.angular = turning.angular;

                break;

            case "Seek Align":
                Align aligning = new Align();
                SteeringOutput turn = new SteeringOutput();

                aligning.character = this;
                aligning.target = aiTarget;        

                moving = seeking.GetSteering();
                turn = aligning.GetSteering();

                movement.linear = moving.linear;
                movement.angular = turn.angular;                

                break;

            case "Seek Face":
                Face faces = new Face
                {
                    character = this,
                    target = aiTarget
                };

                moving = seeking.GetSteering();
                turning = faces.GetSteering();

                if (moving == null)
                {
                    movement.linear = Vector3.zero;
                }
                else
                {
                    movement.linear = moving.linear;
                    movement.angular = turning.angular;
                }

                break;

            case "Seek Look":
                Look_Where_Going looky = new Look_Where_Going();
                SteeringOutput shouldTurn = new SteeringOutput();

                looky.character = this;
                looky.target = aiTarget;

                Debug.Log(looky.GetSteering());

                moving = seeking.GetSteering();
                shouldTurn = looky.GetSteering();

                Debug.Log(looky.GetSteering());
                
                movement.linear = moving.linear;
                movement.angular = shouldTurn.angular;                

                break;

            case "Arrive Align":
                Align aligned = new Align
                {
                    character = this,
                    target = aiTarget
                };

                moving = arrive.GetSteering();
                turning = aligned.GetSteering();

                if (moving == null)
                {
                    movement.linear = Vector3.zero;
                }
                else
                {
                    movement.linear = moving.linear;
                    movement.angular = turning.angular;
                }
                
                break;

            case "Arrive Face":
                Face facing = new Face();

                facing.character = this;
                facing.target = aiTarget;

                //Debug.Log(facing.target);
                //Debug.Log(facing);

                moving = arrive.GetSteering();
                turning = facing.GetSteering();

                //Debug.Log(facing);
                //Debug.Log(turning.angular);

                movement.linear = moving.linear;
                movement.angular = turning.angular;

                //Debug.Log(movement.angular);

                break;

            case "Arrive Look":
                 Look_Where_Going look = new Look_Where_Going
                {
                    character = this,
                    target = aiTarget
                };

                moving = arrive.GetSteering();
                turning = look.GetSteering();

                //Debug.Log(turning.angular);
                
                movement.linear = moving.linear;
                movement.angular = turning.angular;

                Debug.Log(movement.angular);

                break;

            default:
                Face aligns = new Face
                {
                    character = this,
                    target = aiTarget
                };

                moving = seeking.GetSteering();
                turning = aligns.GetSteering();

                if (moving == null)
                {
                    movement.linear = Vector3.zero;
                }
                else
                {
                    movement.linear = moving.linear;
                    movement.angular = turning.angular;
                }

                break;

        }

        // Update linear and angular velocities
        
        //Debug.Log(movement.angular);

        linearVel += movement.linear * Time.deltaTime;
        angularVel += movement.angular * Time.deltaTime;

        //angularInc *= Mathf.Rad2Deg;

        transform.position += linearVel * Time.deltaTime;
        angularInc = new Vector3(0, angularVel * Time.deltaTime, 0);
        //Debug.Log(angularInc);

        transform.eulerAngles += angularInc;       
	}
}
