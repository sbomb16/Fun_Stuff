using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithLaser : RifleDecorator
{

    private float m_LaserAccuracy = 7.5f;
    public string prefabPath = "Rifle With Laser";
    public GameObject model;

    public WithLaser(IRifle rifle) : base(rifle)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_LaserAccuracy;
    }
}
