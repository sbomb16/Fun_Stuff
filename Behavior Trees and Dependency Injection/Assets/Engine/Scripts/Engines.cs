using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetEngine : IEngine
{
    public void StartEngine()
    {
        ActivateJetStream();
        Debug.Log("Engine started");
    }

    private void ActivateJetStream()
    {
        Debug.Log("Jet stream activated");
    }
}

public class NitroEngine : IEngine
{
    public void StartEngine()
    {
        OpenNitroValve();
        Debug.Log("Engine started");
    }

    private void OpenNitroValve()
    {
        Debug.Log("Nitro valve opened");
    }
}

public class LawnMowerEngine : IEngine
{
    public void StartEngine()
    {
        BladesActive();
        Debug.Log("Engine started");
    }

    private void BladesActive()
    {
        Debug.Log("Blades have been activated");
    }
}

public class HandCrankEngine : IEngine
{
    public void StartEngine()
    {
        FlashlightOn();
        Debug.Log("Engine started");
    }

    private void FlashlightOn()
    {
        Debug.Log("Blades have been activated");
    }
}

//public class Engines : MonoBehaviour {

//	// Use this for initialization
//	void Start () {
		
//	}
	
//	// Update is called once per frame
//	void Update () {
		
//	}
//}
