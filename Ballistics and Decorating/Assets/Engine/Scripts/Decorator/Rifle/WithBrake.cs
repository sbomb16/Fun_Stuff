using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithBrake : RifleDecorator
{

    private float m_BrakeAccuracy = 10.0f;
    public string prefabPath = "Rifle With Brake";
    public GameObject model;

    public WithBrake(IRifle rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_BrakeAccuracy;
    }
}
