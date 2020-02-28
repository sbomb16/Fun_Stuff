using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {

    Vector3 nextPos = Vector3.zero;
    IRifle currentRifle;

    public KeyCode[] keys;

    private void Start()
    {
        keys = new KeyCode[6];
        keys[0] = KeyCode.B;
        keys[1] = KeyCode.S;
        keys[2] = KeyCode.T;
        keys[3] = KeyCode.C;
        keys[4] = KeyCode.L;
        keys[5] = KeyCode.A;
    }

    // Update is called once per frame
    void Update () {

        //Event e = Event.current;
        foreach(KeyCode k in keys)
        {
            if (Input.GetKeyDown(k))
            {
                switch (k)
                {
                    case KeyCode.B:

                        IRifle rifle = new BasicRifle(nextPos);

                        if (currentRifle != null)
                        {
                            GameObject.Destroy(currentRifle.GetGameObject());
                            currentRifle = rifle;
                            Debug.Log("Basic Accuracy: " + rifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);                
                        }
                        else
                        {
                            currentRifle = rifle;
                            Debug.Log("Basic Accuracy: " + rifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }

                        break;

                    case KeyCode.S:

                        IRifle sRifle = new BasicRifle(nextPos);
                        sRifle = new WithScope(sRifle);

                        if (currentRifle != null)
                        {
                            GameObject.Destroy(currentRifle.GetGameObject());
                            currentRifle = sRifle;
                            Debug.Log("Scoped Accuracy: " + sRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }
                        else
                        {
                            currentRifle = sRifle;
                            Debug.Log("Scoped Accuracy: " + sRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }

                        break;

                    case KeyCode.T:

                        IRifle tRifle = new BasicRifle(nextPos);
                        tRifle = new WithStabilizer(tRifle);

                        if (currentRifle != null)
                        {
                            GameObject.Destroy(currentRifle.GetGameObject());
                            currentRifle = tRifle;
                            Debug.Log("With Stabilizer: " + tRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }
                        else
                        {
                            currentRifle = tRifle;
                            Debug.Log("With Stabilizer: " + tRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }

                        break;

                    case KeyCode.C:

                        IRifle cRifle = new BasicRifle(nextPos);
                        cRifle = new WithBrake(cRifle);

                        if (currentRifle != null)
                        {
                            GameObject.Destroy(currentRifle.GetGameObject());
                            currentRifle = cRifle;
                            Debug.Log("With Brake: " + cRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }
                        else
                        {
                            currentRifle = cRifle;
                            Debug.Log("With Brake: " + cRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }

                        break;

                    case KeyCode.L:

                        IRifle lRifle = new BasicRifle(nextPos);
                        lRifle = new WithLaser(lRifle);

                        if (currentRifle != null)
                        {
                            GameObject.Destroy(currentRifle.GetGameObject());
                            currentRifle = lRifle;
                            Debug.Log("With Laser: " + lRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }
                        else
                        {
                            currentRifle = lRifle;
                            Debug.Log("With Laser: " + lRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }

                        break;

                    case KeyCode.A:

                        IRifle aRifle = new BasicRifle(nextPos);
                        aRifle = new WithScope(new WithStabilizer(new WithLaser(new WithBrake(aRifle))));

                        if (currentRifle != null)
                        {
                            GameObject.Destroy(currentRifle.GetGameObject());
                            currentRifle = aRifle;
                            Debug.Log("With All: " + aRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }
                        else
                        {
                            currentRifle = aRifle;
                            Debug.Log("With All: " + aRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }

                        break;

                    default:

                        IRifle bRifle = new BasicRifle(nextPos);

                        if (currentRifle != null)
                        {
                            GameObject.Destroy(currentRifle.GetGameObject());
                            currentRifle = bRifle;
                            Debug.Log("Basic Accuracy: " + bRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);                
                        }
                        else
                        {
                            currentRifle = bRifle;
                            Debug.Log("Basic Accuracy: " + bRifle.GetAccuracy());
                            //nextPos += new Vector3(1, 0, 0);
                        }

                        break;
                }
            }            
        }        
	}
}
