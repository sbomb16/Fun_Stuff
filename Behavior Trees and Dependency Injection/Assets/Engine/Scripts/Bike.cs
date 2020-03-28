using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEngine
{
    void StartEngine();
}

public interface IDriver
{
    void Control(Bike bike);
}

public class Bike : MonoBehaviour
{

    private IEngine m_Engine;
    private IDriver m_Driver;

    public void SetEngine(IEngine engine)
    {
        m_Engine = engine;
    }

    public void SetDriver(IDriver driver)
    {
        m_Driver = driver;
    }

    public void StartEngine()
    {
        m_Engine.StartEngine();
        m_Driver.Control(this);
    }

    public void TurnLeft()
    {
        transform.position += new Vector3(-1, 0, 0);
        Debug.Log("The bike is turning left");
    }

    public void TurnRight()
    {
        transform.position += new Vector3(1, 0, 0);
        Debug.Log("The bike is turning right");
    }
}


