using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour {

    public GameObject mouse;
    public float launchForce;
    Rigidbody rigid;

	// Use this for initialization
	void Start () {

        rigid = GetComponent<Rigidbody>();

        CalculatedFiring calcFire = new CalculatedFiring();

        Vector3 targetVect = calcFire.CalculateFiringSolution(transform.position, mouse.transform.position, launchForce, Physics.gravity);

        if (targetVect != Vector3.zero)
        {
            rigid.AddForce(targetVect.normalized * launchForce, ForceMode.VelocityChange);
        }
		
	}
	
}
