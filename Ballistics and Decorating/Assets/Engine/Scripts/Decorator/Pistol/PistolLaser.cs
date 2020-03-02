using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolLaser : PistolDecorator
{

    private float m_LaserAccuracy = 2.5f;
    public string prefabPath = "Pistol With Laser";
    public GameObject model;

    public PistolLaser(IPistol pistol) : base(pistol)
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

    public override float GetAmmoCount()
    {
        return base.GetAmmoCount();
    }
}
