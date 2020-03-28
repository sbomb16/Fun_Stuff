using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public interface Task {

//    bool Run();

//}

public class Task : MonoBehaviour
{
    DoorRange dRange;
    Door2Range dRange2;
    DoorAway dAway;
    DoorLocked dLocked;
    OpenDoor openDoor;
    CloseDoor closeDoor;
    Cat jumpingDoors;

    bool inRange;
    bool doorOpened = false;
    bool kinematicsOff = false;
    bool ready = true;

    public bool jumping = false;
    public bool jumped = false;

    private void Start()
    {
        dRange = new DoorRange();
        dRange2 = new Door2Range();
        dAway = new DoorAway();
        dLocked = new DoorLocked();
        openDoor = new OpenDoor();
        closeDoor = new CloseDoor();
        jumpingDoors = new Cat();
    }
    void ActivateKinematics()
    {
        GetComponent<Kinematics>().enabled = true;
        if(jumped == true)
        {
            jumped = false;
        }
        else
        {
            jumped = true;
        }
    }
    void DeactivateKinematics()
    {
        GetComponent<Kinematics>().enabled = false;
    }

    void OpeningDoor()
    {
        openDoor.Run();
    }

    void ClosingDoor()
    {
        closeDoor.Run();
    }

    void JumpingDoor()
    {
        jumpingDoors.rigid = GetComponent<Rigidbody>();
        Debug.Log(jumped);
        //Debug.Log(jumpingDoors.rigid);
        if(jumped == false)
        {
            jumpingDoors.mouse = GameObject.Find("Point2");
            jumpingDoors.Launch();
            jumped = true;
        }
        else if(jumped == true)
        {
            Debug.Log("Here I am");
            jumpingDoors.mouse = GameObject.Find("Point1");
            jumpingDoors.Launch();
            jumped = false;
        }        
    }

    private void Update()
    {
        if (dRange.Run() == true && doorOpened == false && jumping == false)
        {
            //Debug.Log("I guess I'm here");
            DeactivateKinematics();
            Invoke("OpeningDoor", 1);
            Invoke("ActivateKinematics", 2);
            doorOpened = true;
        }
        if (dAway.Run() == true && doorOpened == true && jumping == false)
        {
            DeactivateKinematics();
            Invoke("ClosingDoor", 1);
            Invoke("ActivateKinematics", 2);
            doorOpened = false;
        }
        if (dRange2.Run() == true && jumping == true && jumped == false)
        {
            //Debug.Log("I guess I'm here");
            DeactivateKinematics();
            Invoke("JumpingDoor", 1);
            Invoke("ActivateKinematics", 4);
            
        }
        if (dRange2.Run() == true && jumping == true && jumped == true)
        {
            Debug.Log("I guess I'm here");
            DeactivateKinematics();
            Invoke("JumpingDoor", 1);
            Invoke("ActivateKinematics", 4);
            //jumped = false;
        }
    }
}

public class DoorRange 
{
    public GameObject character;
    public GameObject target;

    float distance;
    Vector3 direction;
    int doorRadius = 2;

    void GetCharacters()
    {
        target = GameObject.Find("Door");
        character = GameObject.Find("Boy");
        //Debug.Log(target);
        //Debug.Log(character);
    }

    public bool Run()
    {
        GetCharacters();
        direction = character.transform.position - target.transform.position;
        distance = direction.magnitude;
        //Debug.Log(distance);

        if(distance < doorRadius)
        {
            return true;            
        }
        else
        {
            return false;
        }
    }
}

public class Door2Range
{
    public GameObject character;
    public GameObject target;

    float distance;
    Vector3 direction;
    int doorRadius = 2;

    void GetCharacters()
    {
        target = GameObject.Find("Door2");
        character = GameObject.Find("J Boy");
        //Debug.Log(target);
        //Debug.Log(character);
    }

    public bool Run()
    {
        GetCharacters();
        direction = character.transform.position - target.transform.position;
        distance = direction.magnitude;
        //Debug.Log(distance);

        if (distance < doorRadius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class DoorAway
{
    public GameObject character;
    public GameObject target;

    float distance;
    Vector3 direction;
    float doorRadius = 11.7f;

    void GetCharacters()
    {
        target = GameObject.Find("Door");
        character = GameObject.Find("Boy");
        //Debug.Log(target);
        //Debug.Log(character);
    }

    public bool Run()
    {
        GetCharacters();
        direction = character.transform.position - target.transform.position;
        distance = direction.magnitude;
        //Debug.Log(distance);

        if (distance >= doorRadius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class DoorLocked 
{
    public bool doorIsOpen = true;
    public bool Run()
    {
        if(doorIsOpen == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class OpenDoor 
{
    public GameObject target;

    void GetTarget()
    {
        target = GameObject.Find("Door");
    }

    public bool Run()
    {
        GetTarget();
        target.transform.position += new Vector3(0, 10, 0);
        return true;
    }
}

public class CloseDoor 
{
    public GameObject target;

    void GetTarget()
    {
        target = GameObject.Find("Door");
    }

    public bool Run()
    {
        GetTarget();
        target.transform.position -= new Vector3(0, 10, 0);
        return true;
    }
}


