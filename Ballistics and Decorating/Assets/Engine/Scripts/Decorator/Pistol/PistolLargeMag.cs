using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolLargeMag : PistolDecorator
{

    private float m_Ammo_Count = 30f;
    public string prefabPath = "Pistol With Large Magazine";
    public GameObject model;

    public PistolLargeMag(IPistol pistol) : base(pistol)
    {
        GameObject prefab = Resources.Load<GameObject>(prefabPath);
        model = GameObject.Instantiate(prefab);
        model.transform.SetParent(GetGameObject().transform);
        model.transform.position += model.transform.parent.position;
    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy();
    }

    public override float GetAmmoCount()
    {
        return base.GetAmmoCount() + m_Ammo_Count;
    }
}
