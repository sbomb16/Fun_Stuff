using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour {

    public GameObject mouse;

    public float xMin;
    public float xMax;

    public float yMin;
    public float yMax;

    public float zMin;
    public float zMax;

    float newX;
    float newY;
    float newZ;

	// Use this for initialization
	void Start () {

        newX = Random.Range(xMin, xMax);
        newY = Random.Range(yMin, yMax);
        newZ = Random.Range(zMin, zMax);

        mouse.gameObject.transform.position = new Vector3(newX, newY, newZ);

	}
	
	
}
