using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFunny : PistolDecorator
{

    private float m_SightAccuracy = -5f;
    public string prefabPath = "Pistol Funy";
    public GameObject model;

    public PistolFunny(IPistol pistol) : base(pistol)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_SightAccuracy;
    }

    public override float GetAmmoCount()
    {
        return base.GetAmmoCount();
    }
}
