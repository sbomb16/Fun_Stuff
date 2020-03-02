using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithDrum : RifleDecorator {

    private float m_Ammo = 100f;
public string prefabPath = "Rifle With Drum";
public GameObject model;

public WithDrum(IRifle rifle) : base(rifle)
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
    return base.GetAmmoCount() + m_Ammo;
}
}
